﻿using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.RolexWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.RolexWebShop.Drivers
{
    public class ProductPartDriver : ContentPartDriver<ProductPart>
    {

        protected override string Prefix
        {
            get { return "Product"; }
        }

        protected override DriverResult Editor(ProductPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_Product_Edit", () => shapeHelper
                .EditorTemplate(TemplateName: "Parts/Product", Model: part, Prefix: Prefix));
        }

        protected override DriverResult Editor(ProductPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override DriverResult Display(ProductPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_Product", () => shapeHelper.Parts_Product(
                    Price: part.UnitPrice,
                    Description: part.Description,
                    Sku: part.Sku,
                    ShortDescription: part.ShortDescription
                ));
        }
    }
}