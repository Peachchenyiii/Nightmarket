namespace Nightmarket.Migrations
{
    using Nightmarket.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Nightmarket.DAL.NightmarketContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Nightmarket.DAL.NightmarketContext";
        }

        protected override void Seed(Nightmarket.DAL.NightmarketContext context)
        {
            //  This method will be called after migrating to the latest version.

            ////  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //NightmarketInitializer.Seed(context);
        }
    }
}
