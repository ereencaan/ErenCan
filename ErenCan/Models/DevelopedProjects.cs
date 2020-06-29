using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class DevelopedProjects
    {
        public string ProjectName { get; set; }
        public string Language { get; set; }
        public string Platform { get; set; }
        public int Year { get; set; }

        public override string ToString() => JsonSerializer.Serialize<DevelopedProjects>(this);
    }
}
