﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S1.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ins_Id { get; set; }
        public DateOnly HiringDate { get; set; }
    }
}
