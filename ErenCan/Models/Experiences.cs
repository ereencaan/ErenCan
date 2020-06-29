using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class Experiences
    {
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string CompanySector { get; set; }
        public string StartingDate { get; set; }
        public string EndDate { get; set; }
        public string JobType { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Experiences>(this);

    }
}
