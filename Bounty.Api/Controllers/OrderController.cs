using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bounty.IApplication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bounty.Api.Controllers
{
    /// <summary>
    /// 表示订单的控制器。
    /// </summary>
    public class OrderController : AuthController
    {
        private readonly IUserService userService;

        public OrderController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            await this.userService.Get(Guid.NewGuid());
            return new string[] { "value1", "value2" };
        }
    }
}