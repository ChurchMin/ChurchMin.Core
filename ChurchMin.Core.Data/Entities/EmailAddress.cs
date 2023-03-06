﻿using Finbuckle.MultiTenant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data.Entities
{
    [MultiTenant]
    public class EmailAddress : BaseEntity
    {
        public required string Email { get; set; }
        public required string Type { get; set; }

        public required Guid PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
