using System;
using System.Collections.Generic;
using Nightmarket.Models;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Nightmarket.DAL
{
    public class NightmarketContext : DbContext
    {
        public NightmarketContext() : base("NightmarketContext")
        {
        }

        public DbSet<NightMarket> NightMarkets { get; set; }
        public DbSet<Booth> Booths { get; set; }
        public DbSet<Commodity> Commoditys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}