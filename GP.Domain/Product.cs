using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Product
    {

        public int ProductId { get; set; }
        public String Name { get; set; }
        public DateTime DateProduction { get; set; }
        public int Qunaity { get; set; }
        public float Price { get; set; }
        public String Description { get; set; }
        public Category Category { get; set; }
        public List<Provider> Providers { get; set; }


    }
}
