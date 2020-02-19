using System;
using System.Collections.Generic;
using System.Text;
using MathWiz.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MathWiz.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Question> Question { get; set; }
        public DbSet<Test> Test { get; set; }
       // public DbSet<Answer> Answer { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
