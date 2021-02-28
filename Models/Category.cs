using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MtNews.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Agency Agency { get; set; }
        public int AgencyId { get; set; }
    }
}
