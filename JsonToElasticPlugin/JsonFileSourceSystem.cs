using System;
using System.Threading;
using System.Threading.Tasks;
using Catalyst.DataProcessing.Engine.PluginInterfaces;
using Catalyst.DataProcessing.Shared.Models.DataProcessing;
using Catalyst.DataProcessing.Shared.Models.Metadata;

namespace JsonToElasticPlugin
{
    // 	Interact with a system from which a binding is retrieving data

    public class JsonFileSourceSystem : ISourceSystem
    {
        public Task<IncrementalValue> GetMaxIncrementalValueAsync(BindingExecution bindingExecution, Connection connection,
            IncrementalConfiguration incrementalConfiguration, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<DateTime, DateTime>> GetWindowMinAndMaxAsync(EntityExecution entityExecution, Binding binding, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesWindowContainDataAsync(BindingExecution bindingExecution, Binding binding,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool CanHandle(Binding binding)
        {
            throw new NotImplementedException();
        }
    }
}
