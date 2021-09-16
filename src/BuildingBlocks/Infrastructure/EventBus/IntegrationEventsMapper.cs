using System;

namespace Project.EStore.BuildingBlocks.Infrastructure.EventBus
{
    public class IntegrationEventsMapper : IIntegrationEventsMapper
    {
        private readonly BiDictionary<string, Type> _integrationEventsMap;

        public IntegrationEventsMapper(BiDictionary<string, Type> integrationEventsMap)
        {
            _integrationEventsMap = integrationEventsMap;
        }

        public string GetName(Type type)
        {
            return _integrationEventsMap.TryGetBySecond(type, out var name) ? name : null;
        }

        public Type GetType(string name)
        {
            return _integrationEventsMap.TryGetByFirst(name, out var type) ? type : null;
        }
    }
}
