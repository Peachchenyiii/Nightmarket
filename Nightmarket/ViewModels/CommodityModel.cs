using Nightmarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.ViewModels
{
    public class CommodityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Classification { get; set; }
    }
}