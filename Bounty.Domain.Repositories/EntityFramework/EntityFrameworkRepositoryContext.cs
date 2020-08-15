using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.Domain.Repositories.EntityFramework
{
    public abstract class EntityFrameworkRepositoryContext : RepositoryContext, IEntityFrameworkRepositoryContext
    {
        public abstract DbContext Context { get; }

        public async override Task Commit()
        {
            await this.Context.SaveChangesAsync();
        }

        public async override Task Create<TEntity>(TEntity entity)
        {
            await this.Context.AddAsync(entity);
        }

        public async override Task<TEntity> Find<TEntity, TKey>(TKey id)
        {
            return await this.Context.FindAsync<TEntity>(id);
        }

        public override Task Modify<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override Task Remove<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override Task Rollback()
        {
            throw new NotImplementedException();
        }

        #region 释放对象的资源

        /// <summary>
        /// 释放非托管资源和托管资源（后者为可选项）。
        /// </summary>
        /// <param name="disposing">若为 <see cref="true"/>，则同时释放托管资源和非托管资源；若为 <see cref="false"/>，则仅释放非托管资源。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.Context != null)
                    this.Context.Dispose();
            }
        }

        #endregion
    }
}
