using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.Domain.Repositories.EntityFramework
{
    public class EntityFrameworkRepository<TAggregateRoot> : Repository<TAggregateRoot>
         where TAggregateRoot : class, IAggregateRoot
    {
        #region Properties

        private IEntityFrameworkRepositoryContext Context { get; }

        #endregion

        #region Ctor

        public EntityFrameworkRepository(IRepositoryContext context)
        {
            if (context is IEntityFrameworkRepositoryContext)
                this.Context = context as IEntityFrameworkRepositoryContext;
        }

        #endregion

        public async override Task Create(TAggregateRoot entity)
        {
            await this.Context.Create(entity);
        }

        public async override Task<TAggregateRoot> Find<TKey>(TKey id)
        {
            return await this.Context.Find<TAggregateRoot, TKey>(id);
        }

        public async override Task Modify(TAggregateRoot entity)
        {
            await this.Context.Modify(entity);
        }

        public async override Task Remove(TAggregateRoot entity)
        {
            await this.Context.Remove(entity);
        }
    }
}
