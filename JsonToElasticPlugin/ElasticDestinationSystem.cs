using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Catalyst.DataProcessing.Engine.PluginInterfaces;
using Catalyst.DataProcessing.Shared.Models.DataProcessing;
using Catalyst.DataProcessing.Shared.Models.Metadata;

namespace JsonToElasticPlugin
{
    // Interact with a system where an entity physically resides

    class ElasticDestinationSystem : IDestinationSystem
    {
        public Task CreatePhysicalEntityAsync(EntityExecution entityExecution, Entity entity, DataMart dataMart,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<long> PromoteStagedDataAsync(EntityExecution entityExecution, Entity entity, DataMart dataMart,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IDictionary<string, object>> GetExampleDataAsync(EntityExecution entityExecution, Entity entity, ICollection<Field> fieldsToUpdate,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task AddEntityOptimizationsAsync(EntityExecution entityExecution, Entity entity, DataMart dataMart,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task CreateDestinationEntityAsync(EntityExecution entityExecution, Entity entity, DataMart dataMart,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool CanHandle(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
