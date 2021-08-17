using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class EmployeesContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<EmployeesInvite> EmployeesInvites { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public EmployeesContext() : base("Data Source = 192.168.0.172; Initial Catalog = Employees; Persist Security Info=True;User ID = Employees; Password=123321@")
        {

        }
    }
}
