using Finbuckle.MultiTenant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data.Entities
{
    public class Ministry : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Person>? MinistryMembers { get; set; }
    }
}
