using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Events
{
    public class PlatformCancelledEvent : DomainEvent
    {
        public PlatformCancelledEvent(IEntity source)
            : base(source)
        {
        }

        public string Token { get; set; }
    }
}
