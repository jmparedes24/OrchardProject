using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.WatchLinkModule.Models;

namespace Orchard.WatchLinkModule.Handlers
{
    public class WatchLinkHandler : ContentHandler
    {
        public WatchLinkHandler(IRepository<WatchLinkRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}