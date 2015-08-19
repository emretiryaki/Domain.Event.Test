using Domain.Event.Test.Events;

namespace Domain.Event.Test.EventAdd
{
    public interface IDomainHandler<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}