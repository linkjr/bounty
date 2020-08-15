using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Models
{
    /// <summary>
    /// 表示用户钱包的对象。
    /// </summary>
    public class Wallet : AggregateRoot
    {
        public Guid UserID { get; private set; }

        /// <summary>
        /// 获取或设置金额。
        /// </summary>
        public decimal Amount { get; private set; }

        public void Register() { }
    }
}
