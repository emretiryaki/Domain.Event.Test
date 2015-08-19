namespace Domain.Event.Test.Events
{
    public interface IEventDispatcher
    {
        void Dispatch<TEvent>(TEvent @event) where TEvent:IDomainEvent;
    }
}