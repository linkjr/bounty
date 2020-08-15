using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Repositories.EntityFramework
{
    public class BountyRepositoryContext : EntityFrameworkRepositoryContext
    {
        public override DbContext Context { get; }

        public BountyRepositoryContext(BountyDbContext context) => this.Context = context;
    }
}
