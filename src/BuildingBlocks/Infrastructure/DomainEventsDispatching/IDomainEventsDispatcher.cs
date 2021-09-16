using System.Threading.Tasks;

namespace Project.EStore.BuildingBlocks.Infrastructure.DomainEventsDispatching
{
    public interface IDomainEventsDispatcher
    {
        Task DispatchEventsAsync();
    }
}