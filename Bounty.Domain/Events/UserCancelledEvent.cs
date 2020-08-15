using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Events
{
    public class UserCancelledEvent : DomainEvent
    {
        public UserCancelledEvent(IEntity source)
            : base(source)
        {
        }
    }
}
