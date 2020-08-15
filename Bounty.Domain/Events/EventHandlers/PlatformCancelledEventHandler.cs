using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Events.EventHandlers
{
    public class PlatformCancelledEventHandler : DomainEventHandler<PlatformCancelledEvent>
    {
        public override void Handle(PlatformCancelledEvent evnt)
        {
            throw new NotImplementedException();
        }
    }
}
