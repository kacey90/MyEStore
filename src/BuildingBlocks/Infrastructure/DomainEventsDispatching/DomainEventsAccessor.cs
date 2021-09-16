using Microsoft.EntityFrameworkCore;
using Project.EStore.BuildingBlocks.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Project.EStore.BuildingBlocks.Infrastructure.DomainEventsDispatching
{
    public class DomainEventsAccessor : IDomainEventsAccessor
    {
        private readonly DbContext _storeDbContext;

        public DomainEventsAccessor(DbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public IReadOnlyCollection<IDomainEvent> GetAllDomainEvents()
        {
            var domainEntities = this._storeDbContext.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any()).ToList();

            return domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();
        }

        public void ClearAllDomainEvents()
        {
            var domainEntities = this._storeDbContext.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any()).ToList();

            domainEntities
                .ForEach(entity => entity.Entity.ClearDomainEvents());
        }
    }
}
