using System;
using System.Threading;
using System.Threading.Tasks;
using Catalyst.DataProcessing.Engine.PluginInterfaces;
using Catalyst.DataProcessing.Shared.Models.DataProcessing;
using Catalyst.DataProcessing.Shared.Models.Metadata;

namespace JsonToElasticPlugin
{
    // Retrieve data from sourve
    // Apply transformation
    // Stage data so that implementation of IDestinationSystem can promote data to final destination

    class ElasticDataTransformer : IDataTransformer
    {
        public Task<long> TransformDataAsync(BindingExecution bindingExecution, Binding binding, Entity entity,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool CanHandle(BindingExecution bindingExecution, Binding binding, Entity destinationEntity)
        {
            throw new NotImplementedException();
        }
    }
}
