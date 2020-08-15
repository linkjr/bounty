using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Events
{
    /// <summary>
    /// 表示继承于该类的类型为领域事件。
    /// </summary>
    public class DomainEvent : IDomainEvent
    {
        public DomainEvent(IEntity source) => this.Source = source;

        public IEntity Source { get; }

        public static void Publish<TDomainEvent>(TDomainEvent evnt)
            where TDomainEvent : class, IDomainEvent
        {
            //var handlers = ServiceLocator.Instance.ResolveAll<IDomainEventHandler<TDomainEvent, TKey>>();
            //foreach (var handler in handlers)
            //{
            //    handler.Handle(evnt);
            //}
        }
    }
}
