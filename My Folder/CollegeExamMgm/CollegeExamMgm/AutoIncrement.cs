﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeExamMgm
{
    class AutoIncrement
    {
        private int id = 1;
        public int GenerateId()
        {
            return id++;
        }
    }
}
