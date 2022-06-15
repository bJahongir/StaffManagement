using Microsoft.EntityFrameworkCore;
using StaffManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffManagement.DataAccess.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().HasData(
                new Staff
                {
                    Id = 1,
                    FirstName = "Jahongir",
                    LastName = "Buzrukov",
                    Email = "jahongirbuzrukov@gmail.com",
                    Department = Departments.Admin
                },
                new Staff
                {
                    Id = 2,
                    FirstName = "Javohir",
                    LastName = "Buzrukov",
                    Email = "javamagic@gmail.com",
                    Department = Departments.HR
                }
                );
        }
    }
}
