using Nightmarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.ViewModels
{
    public class NightmarketIndexData
    {
        public List<NightMarket> NightMarkets { get; set; }
        public List<Booth> Booths { get; set; }
        public Commodity Commoditys { get; set; }
    }
}