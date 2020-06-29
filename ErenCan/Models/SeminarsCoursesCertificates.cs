using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class SeminarsCoursesCertificates
    {
        public string CertificateName { get; set; }
        public string Institution { get; set; }
        public int Year { get; set; }

        public override string ToString() => JsonSerializer.Serialize<SeminarsCoursesCertificates>(this);
    }
}
