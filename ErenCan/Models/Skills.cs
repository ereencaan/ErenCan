﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ErenCan.Models
{
    public class Skills
    {
        public string Skill { get; set; }
        public string Level { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Skills>(this);
    }
}
