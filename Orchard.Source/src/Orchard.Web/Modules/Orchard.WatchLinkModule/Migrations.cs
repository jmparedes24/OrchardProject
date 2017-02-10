using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.WatchLinkModule.Models;

namespace Orchard.WatchLinkModule {
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table CMSRolex_Orchard_WatchLinkModule_WatchLinkRecord
			SchemaBuilder.CreateTable("CMSRolex_Orchard_WatchLinkModule_WatchLinkRecord", table => table
				.ContentPartRecord()
				.Column("Desciption", DbType.String)
				.Column("Price", DbType.Decimal)
				.Column("Link", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(WatchLinkPart).Name, cfg => cfg
               .Attachable());

            return 1;
        }

        public int UpdateFrom1()
        {
            // Create a new widget content type with our map. We make use of the AsWidgetWithIdentity() helper.
            ContentDefinitionManager.AlterTypeDefinition("WatchLinkWidget", cfg => cfg
                .WithPart("WatchLinkPart"));

            return 2;
        }
    }
}