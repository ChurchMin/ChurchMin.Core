﻿using Finbuckle.MultiTenant;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ChurchMin.Core.Data
{
    class CoreDbFactory : IDesignTimeDbContextFactory<CoreDbContext>
    {
        public CoreDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder().AddUserSecrets<CoreDbFactory>().Build();
            var tenantInfo = new TenantInfo { ConnectionString = config.GetValue("ConnectionString", "") };
            var optionsBuilder = new DbContextOptionsBuilder<CoreDbContext>();
            optionsBuilder.UseSqlServer(tenantInfo.ConnectionString);
            return new CoreDbContext(tenantInfo, optionsBuilder.Options);
        }
    }
}
