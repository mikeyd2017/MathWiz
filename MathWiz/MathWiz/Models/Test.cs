﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathWiz.Models
{
    public class Test
    {
        public int TestID { get; set; }
        public virtual ICollection<Question> Questions { get; set; }


    }
}
