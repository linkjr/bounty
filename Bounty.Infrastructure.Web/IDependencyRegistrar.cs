using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Infrastructure.Web
{
    public interface IDependencyRegistrar
    {
        IServiceCollection Register(IServiceCollection services);
    }
}
