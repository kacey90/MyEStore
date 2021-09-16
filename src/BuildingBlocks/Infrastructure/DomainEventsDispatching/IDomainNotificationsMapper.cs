using System;

namespace Project.EStore.BuildingBlocks.Infrastructure.DomainEventsDispatching
{
    public interface IDomainNotificationsMapper
    {
        string GetName(Type type);

        Type GetType(string name);
    }
}