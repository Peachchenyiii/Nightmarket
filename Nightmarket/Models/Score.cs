using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.Models
{
    public class Score
    {
        public int ScoreId { get; set; }
        public DateTime ScoreDate { get; set; }
        public int ScoreGrade { get; set; }
        public int MemberId { get; set; }
        public int CommodityId { get; set; }

        public virtual Member Member { get; set; }
        public virtual Commodity Commodity { get; set; }
    }
}