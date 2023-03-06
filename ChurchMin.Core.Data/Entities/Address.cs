using Finbuckle.MultiTenant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data.Entities
{
    [MultiTenant]
    public class Address : BaseEntity
    {
        public required string Line1 { get; set; }
        public string? Line2 { get; set; }
        public required string City { get; set; }
        public required string Province { get; set; }
        public string? Code { get; set; }

        public required Guid PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
