using System;

namespace Project.EStore.BuildingBlocks.Domain
{
    public interface IDomainEvent
    {
        Guid Id { get; }

        DateTime OccurredOn { get; }
    }
}