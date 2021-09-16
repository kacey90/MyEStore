using System;

namespace Project.EStore.BuildingBlocks.Infrastructure.EventBus
{
    public interface IIntegrationEventsMapper
    {
        string GetName(Type type);

        Type GetType(string name);
    }
}
