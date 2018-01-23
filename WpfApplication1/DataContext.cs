using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApplication1
{
    class DataContext:DbContext
    {
        public DataContext():base(@"Data Source=DESKTOP-C3NTTGB\M_MAHANNY;Initial Catalog=ITI-project;Integrated Security=True")
        {
        }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Trainee> Student { get; set; }
        public DbSet<Track> Tarck { get; set; }
        public DbSet<Intake> Intake { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}
