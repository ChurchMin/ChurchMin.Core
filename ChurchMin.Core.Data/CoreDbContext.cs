using ChurchMin.Core.Data.Entities;
using Finbuckle.MultiTenant;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data
{
    public class CoreDbContext : MultiTenantDbContext
    {
        public CoreDbContext(ITenantInfo tenantInfo) : base(tenantInfo)
        {
        }

        public CoreDbContext(ITenantInfo tenantInfo, DbContextOptions options) : base(tenantInfo, options)
        {
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<EmailAddress> EmailAddress { get; set; }
        public DbSet<Family> Family { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }
        public DbSet<Ministry> Ministry { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
