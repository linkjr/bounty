using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Models
{
    public class Project : AggregateRoot
    {
        /// <summary>
        /// 获取或设置可参与人数。
        /// </summary>
        public int Participants { get; private set; }

        /// <summary>
        /// 获取或设置发布用户ID。
        /// </summary>
        public Guid UserID { get; private set; }
    }
}
