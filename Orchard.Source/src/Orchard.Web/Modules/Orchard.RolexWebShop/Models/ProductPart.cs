using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.RolexWebShop.Models
{
    public class ProductPart: ContentPart<ProductPartRecord>
    {
        public decimal UnitPrice
        {
            get { return Record.UnitPrice; }
            set { Record.UnitPrice = value; }
        }

        public string Sku
        {
            get { return Record.Sku; }
            set { Record.Sku = value; }
        }

        public string  Description
        {
            get { return Record.Description; } 
            set { Record.Description = value; }
        }

        public string ShortDescription
        {
            get { return Record.ShortDescription; }
            set { Record.ShortDescription = value; }
        }
    }
}