using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{

    public class RamContext : DbContext
    {
        public RamContext() : base("DefaultConnection")
        {

        }
        public DbSet<Ram> Rams { get; set; }
    }
    public class Ram
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string RamSize { get; set; }
        public double Price { get; set; }

    }
}
