using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MtNews.Models
{
    public class Agency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Type { get; set; } //search if we can put type restricted to three values only.
        public string MtType { get; set; }

    }
}
