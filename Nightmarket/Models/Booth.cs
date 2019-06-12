using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.Models
{
    public class Booth
    {
        public int BoothId { get; set; }
        public string BoothName { get; set; }
        public string BoothLocation { get; set; }
        public string Operator { get; set; }
        public string BoothIntroduction { get; set; }
        public int CommodityId { get; set; }
        public int NightmarketId { get; set; }

        public virtual ICollection<Commodity> Commoditys { get; set; }
        public virtual ICollection<NightMarket> NightMarkets { get; set; }

    }
}