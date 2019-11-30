using CarRent.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Data
{
    public class MyAppDataContext : IdentityDbContext
    {
        public MyAppDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Passport> Passports { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<RentedCars> RentedCars { get; set; }
  
    }
}
