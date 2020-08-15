using Bounty.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bounty.Api.Controllers
{
    /// <summary>
    /// 表示账户信息的控制器。
    /// </summary>
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// 登录系统。
        /// </summary>
        /// <param name="model">登录视图模型。</param>
        /// <returns></returns>
        [HttpPost("signin")]
        public async Task SignIn([FromBody]SignInViewModel model)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// 退出系统。
        /// </summary>
        /// <returns></returns>
        [HttpPost("signout")]
        [Authorize]
        public async Task SignOut()
        {
            await Task.CompletedTask;
        }
    }
}