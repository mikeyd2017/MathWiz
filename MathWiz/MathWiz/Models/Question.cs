using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathWiz.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public decimal Val1 { get; set; }
        public decimal Val2 { get; set; }
        public decimal Answer { get; set; }
        public string Sign { get; set; }
        public bool Correct { get; set; }

    }
}
