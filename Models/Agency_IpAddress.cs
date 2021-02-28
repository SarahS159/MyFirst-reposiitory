using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MtNews.Models
{
    public class Agency_IpAddress
    {
        public int Id { get; set; }
        public Agency Agency { get; set; }
        public int AgencyId { get; set; }   
        public IpAddress IpAddress { get; set; }
        public int IpAddressId { get; set; }
    }
}
