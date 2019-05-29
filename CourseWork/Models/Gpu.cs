using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class GpuContext : DbContext
    {
        public GpuContext() : base("ConfiguratorDB")
        {

        }
        public DbSet<Gpu> GPUs { get; set; }
    }
    public class Gpu
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string GpuMemory { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }      
        public double Price { get; set; }
    }

}
