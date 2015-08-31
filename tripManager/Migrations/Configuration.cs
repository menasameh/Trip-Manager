namespace tripManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using tripManager.model;

    internal sealed class Configuration : DbMigrationsConfiguration<tripManager.controller.context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "tripManager.controller.context";
        }

        protected override void Seed(tripManager.controller.context context)
        {
            
        }
    }
}
