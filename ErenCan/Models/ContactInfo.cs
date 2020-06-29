using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class ContactInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<ContactInfo>(this);
    }
}
