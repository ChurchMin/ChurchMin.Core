using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Contracts.v1.Responses
{
    public class PhoneResponse
    {
        public Guid Id { get; set; }
        public required string Phone { get; set; }
        public required string Type { get; set; }
    }
}
