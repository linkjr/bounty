using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bounty.Api.Models
{
    public class AccountViewModel
    {

    }

    /// <summary>
    /// 表示登录的视图模型。
    /// </summary>
    public class SignInViewModel
    {
        /// <summary>
        /// 获取或设置账号。
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 获取或设置验证码。
        /// </summary>
        public string Captch { get; set; }
    }
}
