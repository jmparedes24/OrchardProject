
using Orchard.ContentManagement;

namespace Orchard.WatchLinkModule.Models
{
    public class WatchLinkPart : ContentPart<WatchLinkRecord>
    {
        public string Description
        {
            get { return Retrieve(x => x.Desciption); }
            set { Store(y => y.Desciption, value); }
        }

        public decimal Price
        {
            get { return Retrieve(x => x.Price); }
            set { Store(y => y.Price, value); }
        }

        public string Link
        {
            get { return Retrieve(x => x.Link); }
            set { Store(y => y.Link, value); }
        }


    }
}