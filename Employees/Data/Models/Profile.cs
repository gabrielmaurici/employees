﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Profile : Base
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Description { get; set; }
    }
}
