using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MtNews.Models
{
    public class MtNewsContext : DbContext
    {
        private readonly DbContextOptions _options;
        public MtNewsContext(DbContextOptions<MtNewsContext> options) : base(options)
        {
            _options = options;
        }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<IpAddress> IpAddresses { get; set; }
        public DbSet<Agency_IpAddress> Agencies_IpAddresses { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Agency_Permission> Agencies_Permissions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sender> Senders { get; set; }
        public DbSet<Agency_Sender> Agencies_senders { get; set; }
    }
}
