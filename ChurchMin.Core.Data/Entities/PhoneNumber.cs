using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data.Entities
{
    public class PhoneNumber : BaseEntity
    {
        public required string Phone { get; set; }
        public required string Type { get; set; }

        public required Guid PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
