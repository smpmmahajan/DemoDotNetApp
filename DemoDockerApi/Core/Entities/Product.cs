using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDockerAPI.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public bool IsActivated { get; set; }
        public DateTime Cdate { get; set; }
        public DateTime Udate { get; set; }
    }
}
