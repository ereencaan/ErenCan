using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class Languages
    {
        public string ForeignLanguages { get; set; }
        public string Level { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Languages>(this);
    }
}
