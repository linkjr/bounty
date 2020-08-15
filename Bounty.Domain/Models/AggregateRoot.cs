using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Models
{
    /// <summary>
    /// 表示聚合根类型的基类。
    /// </summary>
    public class AggregateRoot : Entity, IAggregateRoot
    {
        /// <summary>
        /// 获取或设置是否禁用。
        /// </summary>
        public bool Disabled { get; private set; }

        /// <summary>
        /// 禁用。
        /// </summary>
        public void Disable()
        {
            this.Disabled = true;
        }
    }
}
