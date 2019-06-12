using Nightmarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.DAL
{
    public class NightmarketInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NightmarketContext>
    {
        protected override void Seed(NightmarketContext context)
        {
            var students = new List<NightMarket>
            {
            // 2個夜市
            new NightMarket{NightmarketName="Alexander",NightmarketIntroduction="aaa"},
            new NightMarket{NightmarketName="Alexander",NightmarketIntroduction="aaa"}
            };

            students.ForEach(s => context.NightMarkets.Add(s));
            context.SaveChanges();
            var courses = new List<Booth>
            {
            // 20個攤位
            new Booth{BoothName="aaa",BoothLocation="aaa",Operator="aaa",BoothIntroduction="aaa"},
            };

            courses.ForEach(s => context.Booths.Add(s));
            context.SaveChanges();
            var enrollments = new List<Commodity>
            {
            // 20個商品
            new Commodity{CommodityName="aaa",CommodityPrice=321,CommodityClassification="aaa"},
            };
            enrollments.ForEach(s => context.Commoditys.Add(s));
            context.SaveChanges();
        }
    }
}