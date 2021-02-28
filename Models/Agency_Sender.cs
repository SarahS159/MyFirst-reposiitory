using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MtNews.Models
{
    public class Agency_Sender
    {
        public int Id { get; set; }
        public Agency Agency { get; set; }
        public int AgencyId { get; set; }
        public Sender Sender { get; set; }
        public int SenderId { get; set; }
    }
}
