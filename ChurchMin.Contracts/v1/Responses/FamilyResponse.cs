using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Contracts.v1.Responses
{
    public class FamilyResponse
    {
        public Guid Id { get; set; }
        public required string FamilyName { get; set; }
        public ICollection<PersonResponse>? FamilyMembers { get; set; }
    }
}
