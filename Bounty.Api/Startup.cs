using Bounty.Application;
using Bounty.Domain.Repositories;
using Bounty.Domain.Repositories.EntityFramework;
using Bounty.IApplication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BountyDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRepositoryContext, BountyRepositoryContext>();

            //services.DependencyRegister();

            //Authentication.
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    //JwtBearer认证中，默认是通过Http的Authorization头来获取的，这也是最推荐的做法，但是在某些场景下，我们可能会使用Url或者是Cookie来传递Token
                    //http://www.cnblogs.com/RainingNight/p/jwtbearer-authentication-in-asp-net-core.html#自定义token获取方式
                    options.Events = new JwtBearerEvents
                    {
                        OnMessageReceived = async context =>
                        {
                            context.Token = context.Request.Query["access_token"];
                            await Task.CompletedTask;
                        }
                    };
                    //JwtBearer认证配置
                    var key = Encoding.UTF8.GetBytes(this.Configuration["jwt:payload:secret"]);
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = this.Configuration["jwt:payload:iss"],
                        ValidAudience = this.Configuration["jwt:payload:aud"],
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                    };
                });

            //Api Document.
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Bounty Api"
                });
                options.OperationFilter<HttpHeaderOperationFilter>();

                Directory.GetFiles(AppContext.BaseDirectory, "*.xml").ToList().ForEach(p => options.IncludeXmlComments(p));
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger(options => options.PreSerializeFilters.Add((swagger, httpReq) => swagger.Host = httpReq.Host.Value))
                    .UseSwaggerUI(options =>
                    {
                        options.RoutePrefix = string.Empty;
                        options.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");
                    });
            }

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
