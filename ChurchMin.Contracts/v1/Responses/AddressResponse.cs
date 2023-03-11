using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Contracts.v1.Responses
{
    public class AddressResponse
    {
        public Guid Id { get; set; }
        public required string Line1 { get; set; }
        public string? Line2 { get; set; }
        public required string City { get; set; }
        public required string Province { get; set; }
        public string? Code { get; set; }
    }
}
