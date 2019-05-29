using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class ConfigContext : DbContext
    {
        public ConfigContext() : base("DefaultConnection")
        {

        }
        public DbSet<Config> Configs { get; set; }
    }
    public class Config
    {
        public string Cpu { get; set; }
        public string Gpu { get; set; }
        public string Motherboard { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string Power { get; set; }
        public string CasePC { get; set; }
        public string TotalPrice { get; set; }
        public string PersonID { get; set; }
    }
}
