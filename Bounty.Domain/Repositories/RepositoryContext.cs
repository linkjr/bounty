using Bounty.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.Domain.Repositories
{
    public abstract class RepositoryContext : DisposableObject, IRepositoryContext
    {
        public abstract Task Create<TEntity>(TEntity entity)
            where TEntity : class, IAggregateRoot;

        public abstract Task Remove<TEntity>(TEntity entity)
            where TEntity : class, IAggregateRoot;

        public abstract Task Modify<TEntity>(TEntity entity)
            where TEntity : class, IAggregateRoot;

        public abstract Task<TEntity> Find<TEntity, TKey>(TKey id)
            where TEntity : class, IAggregateRoot;

        /// <summary>
        /// 提交事务。
        /// </summary>
        /// <returns></returns>
        public abstract Task Commit();

        /// <summary>
        /// 回滚事务。
        /// </summary>
        /// <returns></returns>
        public abstract Task Rollback();
    }
}
