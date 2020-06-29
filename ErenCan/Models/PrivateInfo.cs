using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class PrivateInfo
    {
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string ExpectedSalary { get; set; }
        public string DriverLicense { get; set; }
        public string MilitaryServices { get; set; }

        public override string ToString() => JsonSerializer.Serialize<PrivateInfo>(this);
    }
}
