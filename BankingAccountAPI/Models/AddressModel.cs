using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAccountAPI.Models
{
    public class AddressModel
    {
        public string Id { get; set; }
        public string StreetName { get; set; }
        public string TownName { get; set; }
        public string State { get; set; }

    }
}
