using Nightmarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.ViewModels
{
    public class BoothModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Operator { get; set; }
        public string Introduction { get; set; }

        public List<CommodityModel> Commoditys { get; set; }
    }
}