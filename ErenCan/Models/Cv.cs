using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class Cv
    {
        [JsonPropertyName("imgTurkish")]
        public string Turkish { get; set; }
        
        [JsonPropertyName("imgEnglish")]
        public string English { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Cv>(this);
    }
}
