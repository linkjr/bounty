using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Models
{
    /// <summary>
    /// 表示任务的对象。
    /// </summary>
    public class Product : AggregateRoot
    {
        /// <summary>
        /// 获取或设置价格。
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        /// 获取或设置库存。
        /// </summary>
        public int Sotcks { get; private set; }

        /// <summary>
        /// 获取或设置截止日期。
        /// </summary>
        public DateTime Deadline { get; private set; }

        /// <summary>
        /// 获取或设置发布用户ID。
        /// </summary>
        public Guid UserID { get; private set; }
    }
}
