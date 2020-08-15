using Bounty.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Models
{
    /// <summary>
    /// 表示开放平台的对象。
    /// </summary>
    public class OpenPlatform : AggregateRoot
    {
        /// <summary>
        /// 获取或设置开放平台ID。
        /// </summary>
        public string OpenID { get; private set; }

        /// <summary>
        /// 获取或设置平台。
        /// </summary>
        public PlatformOptions Platform { get; private set; }

        /// <summary>
        /// 获取或设置用户ID。
        /// </summary>
        public Guid UserID { get; private set; }

        public void Cancel()
        {
            DomainEvent.Publish(new PlatformCancelledEvent(this));
        }
    }

    /// <summary>
    /// 表示开放平台的项。
    /// </summary>
    public enum PlatformOptions
    {
        Weibo = 1,
        WeChat = 2
    }
}
