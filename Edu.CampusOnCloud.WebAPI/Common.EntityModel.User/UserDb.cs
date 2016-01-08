using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Common.EntityModel.User
{
    public partial class UserDb : DbContext
    {
        public UserDb()
            : base("UserDb")
        {
            //Database.SetInitializer(null as IDatabaseInitializer<CoreDb>);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UserDb, Migrations.Configuration>());
        }

        public UserDb(System.Data.Common.DbConnection dbConnection)
            : base(dbConnection, true)
        {
            //Database.SetInitializer(null as IDatabaseInitializer<CoreDb>);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UserDb, Migrations.Configuration>());
        }
    }
}
