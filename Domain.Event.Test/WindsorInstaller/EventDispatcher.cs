using System.Linq;
using Castle.Windsor;
using Domain.Event.Test.EventAdd;
using Domain.Event.Test.Events;

namespace Domain.Event.Test.WindsorInstaller
{
    public class EventDispatcher : IEventDispatcher
    {
        private readonly IWindsorContainer container;

        public EventDispatcher(IWindsorContainer container)
        {
            this.container = container;
        }

        public void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent
        {
            var handlers = this.container.ResolveAll<IDomainHandler<TEvent>>().ToList();
            try
            {
                handlers.ForEach(x => x.Handle(eventToDispatch));
            }
            finally
            {
                handlers.ForEach(x => this.container.Release(x));
            }
        }
    }
}