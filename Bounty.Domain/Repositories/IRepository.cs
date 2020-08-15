using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.Domain.Repositories
{
    /// <summary>
    /// 表示继承于该接口的类型是应用于某种聚合根的仓储类型。
    /// </summary>
    /// <typeparam name="TAggregateRoot">聚合根类型。</typeparam>
    public interface IRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        Task Create(TAggregateRoot entity);

        Task Remove(TAggregateRoot entity);

        Task Modify(TAggregateRoot entity);

        Task<TAggregateRoot> Find<TKey>(TKey id);
    }
}
