using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.Models
{
    public class NightMarket
    {
        public int NightmarketId { get; set; }
        public string NightmarketName { get; set; }
        public string NightmarketIntroduction { get; set; }

        public virtual Booth Booth { get; set; }
    }
}