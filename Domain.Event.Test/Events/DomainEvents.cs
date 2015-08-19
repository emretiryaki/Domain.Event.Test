namespace Domain.Event.Test.Events
{
    public static class DomainEvents
    {
        private static IEventDispatcher Dispatcher { get; set; }

        public static void Raise<T>(T @event) where T : IDomainEvent
        {
            Dispatcher.Dispatch(@event);
        }

        public static void SetDispatcher(IEventDispatcher eventDispatcher)
        {
            Dispatcher = eventDispatcher;
        }

    }
}