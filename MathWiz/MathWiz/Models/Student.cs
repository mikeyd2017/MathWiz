using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathWiz.Models
{
    public class Student : IdentityUser
    {
        public int StudentID { get; set; }
    }
}
