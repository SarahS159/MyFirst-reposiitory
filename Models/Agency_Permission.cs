using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MtNews.Models
{
    public class Agency_Permission
    {
        public int Id { get; set; }
        public Agency Agency { get; set; }
        public int AgencyId { get; set; }
        public Permission Permission { get; set; }
        public int PermissionId { get; set; }
    }
}
