using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.RolexWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.RolexWebShop.Handlers
{
    public class ProductPartHandler : ContentHandler
    {
        public ProductPartHandler(IRepository<ProductPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}