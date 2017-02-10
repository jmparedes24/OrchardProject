using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.WatchLinkModule.Models;

namespace Orchard.WatchLinkModule.Drivers
{
    public class WatchLinkgDriver: ContentPartDriver<WatchLinkPart>
    {
        protected override DriverResult Display(WatchLinkPart part, string displayType, dynamic shapeHelper) {

            return ContentShape("Parts_WatchLink", () => shapeHelper.Parts_WatchLink(
               Description: part.Description,
               Price: part.Price,
               Link: part.Link ));
        }

        //GET
        protected override DriverResult Editor(
            WatchLinkPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_WatchLink_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/WatchLink",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(
            WatchLinkPart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}