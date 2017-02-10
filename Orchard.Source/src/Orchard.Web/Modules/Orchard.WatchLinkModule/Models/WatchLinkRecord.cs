using Orchard.ContentManagement.Records;

namespace Orchard.WatchLinkModule.Models
{
    public class WatchLinkRecord : ContentPartRecord
    {
        public virtual string Desciption { get; set; }

        public virtual decimal Price { get; set; }

        public virtual string Link { get; set; }
    }
}