using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Collections.Generic;

namespace Common.EntityModel.User.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<Common.EntityModel.User.UserDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Common.EntityModel.User.UserDb";
        }

        protected override void Seed(Common.EntityModel.User.UserDb db)
        {
        }
    }
}
