using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentApplicationManagementSystem.Models;

namespace StudentApplicationManagementSystem.Data
{
    public class StudentApplicationManagementSystemContext : DbContext
    {
        public StudentApplicationManagementSystemContext (DbContextOptions<StudentApplicationManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<StudentApplicationManagementSystem.Models.Applicant> Applicant { get; set; } = default!;
        public DbSet<StudentApplicationManagementSystem.Models.University> University { get; set; } = default!;
        public DbSet<StudentApplicationManagementSystem.Models.Specialty> Specialty { get; set; } = default!;
        public DbSet<StudentApplicationManagementSystem.Models.StudentApplication> StudentApplication { get; set; } = default!;
        public DbSet<StudentApplicationManagementSystem.Models.Degree> Degree { get; set; } = default!;
        public DbSet<StudentApplicationManagementSystem.Models.ApplicationStatus> ApplicationStatus { get; set; } = default!;
        public DbSet<StudentApplicationManagementSystem.Models.FundingType> FundingType { get; set; } = default!;
    }
}
