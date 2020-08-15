using Bounty.Domain.Repositories;
using Bounty.IApplication;
using System;

namespace Bounty.Application
{
    public class AppService : IAppService
    {
        /// <summary>
        /// 初始化 <see cref="AppService"/> 类的新实例。
        /// </summary>
        /// <param name="context"></param>
        public AppService(IRepositoryContext context) => this.Context = context;

        /// <summary>
        /// 获取仓储上下文。
        /// </summary>
        protected IRepositoryContext Context { get; }
    }
}
