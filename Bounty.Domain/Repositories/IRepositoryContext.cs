using Bounty.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.Domain.Repositories
{
    /// <summary>
    /// 表示实现该接口的类型是仓储上下文。
    /// </summary>
    public interface IRepositoryContext : IUnitOfWork, IDisposable
    {
        Task Create<TEntity>(TEntity entity)
            where TEntity : class, IAggregateRoot;

        Task Remove<TEntity>(TEntity entity)
            where TEntity : class, IAggregateRoot;

        Task Modify<TEntity>(TEntity entity)
            where TEntity : class, IAggregateRoot;

        Task<TEntity> Find<TEntity, TKey>(TKey id)
            where TEntity : class, IAggregateRoot;
    }
}
