using Finbuckle.MultiTenant;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data
{
    class CoreDbFactory : IDesignTimeDbContextFactory<CoreDbContext>
    {
        public CoreDbContext CreateDbContext(string[] args)
        {
            var tenantInfo = new TenantInfo { ConnectionString = @"Server=localhost;Database=ChurchMin;User Id=church;Password=church;MultipleActiveResultSets=true" };
            var optionsBuilder = new DbContextOptionsBuilder<CoreDbContext>();
            optionsBuilder.UseSqlServer(tenantInfo.ConnectionString);
            return new CoreDbContext(tenantInfo, optionsBuilder.Options);
        }
    }
}
