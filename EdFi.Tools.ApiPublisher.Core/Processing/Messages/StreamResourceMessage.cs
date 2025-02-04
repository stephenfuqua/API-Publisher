using System;
using System.Threading;
using System.Threading.Tasks;
using EdFi.Tools.ApiPublisher.Core.ApiClientManagement;

namespace EdFi.Tools.ApiPublisher.Core.Processing.Messages
{
    public class StreamResourceMessage
    {
        public EdFiApiClient EdFiApiClient { get; set; }
        public string ResourceUrl { get; set; }
        public Task[] Dependencies { get; set; }

        public string[] DependencyPaths { get; set; }
        public int PageSize { get; set; }
        
        public ChangeWindow ChangeWindow { get; set; }
        
        public CancellationTokenSource CancellationSource { get; set; }

        public Action<object> PostAuthorizationFailureRetry { get; set; }
        
        public bool ShouldSkip { get; set; }
        
        public SemaphoreSlim ProcessingSemaphore { get; set; }
    }
}