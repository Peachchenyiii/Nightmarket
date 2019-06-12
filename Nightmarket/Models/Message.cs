using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public DateTime MessageDate { get; set; }
        public string MessageContent { get; set; }
        public int MemberId { get; set; }
        public int CommodityId { get; set; }

        public virtual Member Member { get; set; }
        public virtual Commodity Commodity { get; set; }
    }
}