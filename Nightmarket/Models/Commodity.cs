using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.Models
{
    public class Commodity
    {
        public int CommodityId { get; set; }
        public String CommodityName { get; set; }
        public decimal CommodityPrice { get; set; }
        public string CommodityClassification { get; set; }
        public int BoothId { get; set; }

        public virtual ICollection<Booth> Booths { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}