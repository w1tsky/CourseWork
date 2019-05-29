using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{

    public class CpuContext : DbContext
    {
        public CpuContext() : base("DefaultConnection")
        {

        }
        public DbSet<Cpu> CPUs { get; set; }
    }
    public class Cpu
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string Socket { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public double Price { get; set; }
        
    }
}
