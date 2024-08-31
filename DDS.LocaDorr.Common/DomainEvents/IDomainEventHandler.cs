using MediatR;

namespace DDS.LocaDorr.Common.DomainEvents;

public interface IDomainEventHandler<TDomainEvent>
    : INotificationHandler<TDomainEvent> where TDomainEvent : IDomainEvent
{
}