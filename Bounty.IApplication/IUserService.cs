using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.IApplication
{
    public interface IUserService : IAppService
    {
        Task Get(Guid id);
    }
}
