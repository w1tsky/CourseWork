using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class MotherboardContext : DbContext
    {
        public MotherboardContext() : base("DefaultConnection")
        {

        }
        public DbSet<Motherboard> Motherboards { get; set; }
    }
    public class Motherboard
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public double Price { get; set; }
    }
}

