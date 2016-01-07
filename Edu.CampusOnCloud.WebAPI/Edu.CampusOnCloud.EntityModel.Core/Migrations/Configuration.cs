using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Collections.Generic;

namespace Edu.CampusOnCloud.EntityModel.Core.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<Edu.CampusOnCloud.EntityModel.Core.CoreDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Edu.CampusOnCloud.EntityModel.Core.CoreDb";
        }

        protected override void Seed(Edu.CampusOnCloud.EntityModel.Core.CoreDb db)
        {

        }
    }
}
