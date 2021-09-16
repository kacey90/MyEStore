using System.Threading.Tasks;

namespace Project.EStore.BuildingBlocks.Application.Outbox
{
    public interface IOutbox
    {
        void Add(OutboxMessage message);

        Task Save();
    }
}
