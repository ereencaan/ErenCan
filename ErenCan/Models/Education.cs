using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class Education
    {
        public string UniversityName { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string GraduationType { get; set; }
        public string Language { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Education>(this);
    }
}
