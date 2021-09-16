using System;

namespace Project.EStore.BuildingBlocks.Application
{
    public interface IExecutionContextAccessor
    {
        Guid UserId { get; }

        Guid CorrelationId { get; }

        bool IsAvailable { get; }
    }
}
