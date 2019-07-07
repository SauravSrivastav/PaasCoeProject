using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PaasCoe.Models
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext (DbContextOptions<EmployeesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<PaasCoe.Models.Employee> Employee { get; set; }
    }
}
