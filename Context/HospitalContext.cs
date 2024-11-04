using HospitalPatientAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HospitalPatientAPI.Context
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
    }
}

