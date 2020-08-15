using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Events.EventHandlers
{
    public abstract class DomainEventHandler<TDomainEvent> : IDomainEventHandler<TDomainEvent>
        where TDomainEvent : class, IDomainEvent
    {
        public abstract void Handle(TDomainEvent evnt);
    }
}
