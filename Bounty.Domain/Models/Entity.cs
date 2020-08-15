using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Models
{
    /// <summary>
    /// 表示领域实体类型的基类。
    /// </summary>
    public class Entity : IEntity
    {
        /// <summary>
        /// 获取当前领域实体类的全局唯一标识。
        /// </summary>
        public Guid ID { get; private set; }

        /// <summary>
        /// 获取或设置行版本。
        /// </summary>
        public byte[] RowVersion { get; private set; }
    }
}
