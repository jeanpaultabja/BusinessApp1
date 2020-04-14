using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessApp1.Models;
using Microsoft.EntityFrameworkCore;


namespace BusinessApp1.Services
{
  
   
        public class StudentDbContext : DbContext
        {
            public StudentDbContext(
            DbContextOptions<StudentDbContext> options
                ) : base(options) { }
            public DbSet<Student> Students { get; set; }
        }
   

 }
