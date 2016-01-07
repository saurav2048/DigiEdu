using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Edu.CampusOnCloud.EntityModel.Core
{
    public partial class CoreDb : DbContext
    {
        public CoreDb()
            : base("CoreDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CoreDb, Migrations.Configuration>());
        }

        public CoreDb(System.Data.Common.DbConnection dbConnection)
            : base(dbConnection, true)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CoreDb, Migrations.Configuration>());
        }
    }
}
