using System;
using MediatR;

namespace Framework.Domain.Events
{
    public interface IDomainEvent : INotification
    {
        Guid Id => Guid.NewGuid();
        DateTime CreatedAt =>DateTime.Now;
        string EventName { get; }
    }
}