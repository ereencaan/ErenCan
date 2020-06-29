using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class Summary
    {
        public string MySummary { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Summary>(this);
    }
}
