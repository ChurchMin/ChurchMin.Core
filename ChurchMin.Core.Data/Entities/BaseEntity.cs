using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data.Entities
{
    public class BaseEntity
    {
        public required Guid Id { get; set; }

        [ConcurrencyCheck]
        [Timestamp]
        public required byte[] Version { get; set; }
        public required string CreatedBy { get; set; }
        public required DateTime CreatedDateTime { get; set; }
        public required string LastModifiedBy { get; set; }
        public required DateTime LastModifiedDateTime { get; set; }
    }
}
