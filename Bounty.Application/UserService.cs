using Bounty.Domain.Repositories;
using Bounty.IApplication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bounty.Application
{
    public class UserService : AppService, IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IRepositoryContext context,
            IUserRepository userRepository)
            : base(context)
        {
            this.userRepository = userRepository;
        }

        public async Task Get(Guid id)
        {
            var model = await this.userRepository.Find(id);
        }
    }
}
