using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.Domain.Repositories
{
    public abstract class Repository<TAggregateRoot> : IRepository<TAggregateRoot>
         where TAggregateRoot : class, IAggregateRoot
    {
        #region Methods

        public abstract Task Create(TAggregateRoot entity);

        public abstract Task<TAggregateRoot> Find<TKey>(TKey id);

        public abstract Task Modify(TAggregateRoot entity);

        public abstract Task Remove(TAggregateRoot entity);

        #endregion
    }
}
