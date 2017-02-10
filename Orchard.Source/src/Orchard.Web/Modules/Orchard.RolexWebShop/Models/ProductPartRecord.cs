using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.RolexWebShop.Models
{
    public class ProductPartRecord: ContentPartRecord
    {
        public virtual decimal UnitPrice { get; set; }
        public virtual string Sku { get; set; }

        public virtual string Description { get; set; }

        public virtual string ShortDescription { get; set; }
    }
}