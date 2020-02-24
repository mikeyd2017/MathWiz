using MathWiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathWiz.BizLogic
{
    public class QuestionsHelper
    {
        List<Question> qlist = new List<Question>()
        {
            new Question(){Val1=1,Val2=2,Answer=3},
            new Question(){Val1=1,Val2=2,Answer=3},
            new Question(){Val1=1,Val2=2,Answer=3},
            new Question(){Val1=1,Val2=2,Answer=3},
            new Question(){Val1=1,Val2=2,Answer=3},
            new Question(){Val1=1,Val2=2,Answer=3},
            new Question(){Val1=1,Val2=2,Answer=3},
            new Question(){Val1=1,Val2=2,Answer=3},
            new Question(){Val1=1,Val2=2,Answer=3},
            new Question(){Val1=1,Val2=2,Answer=3},
        };

        public List<Question> getQuestions()
        {
            
            return qlist;
        }
        
        public double Addition(double val1, double val2) {
            return val1 + val2;
        }

        public double Subtraction(double val1, double val2)
        {
            return val1 - val2;
        }

        public double Multiplication(double val1, double val2)
        {
            return val1 * val2;
        }

        public double RunQuestion(string sign, double val1, double val2)
        {
            if (sign == "+")
            {
                return Addition(val1, val2);
            }
            else if (sign == "-")
            {
                return Subtraction(val1, val2);
            }
            else if (sign == "*")
            {
                return Multiplication(val1, val2);
            }

            return 00.00;
        }


    }
}
