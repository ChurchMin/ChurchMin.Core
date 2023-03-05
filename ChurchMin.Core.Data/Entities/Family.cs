using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data.Entities
{
    public class Family : BaseEntity
    {
        public required string FamilyName { get; set; }
        public ICollection<Person>? FamilyMembers { get; set; }
    }
}
