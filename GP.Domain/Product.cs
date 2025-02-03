using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string name, string description, float price, DateTime dateProduction, int qunaity)
        {
            Name = name;
            Description = description;
            Price = price;
            DateProduction = dateProduction;
            Qunaity = qunaity;
        }

        public int ProductId { get; set; }
        public String Name { get; set; }
        public DateTime DateProduction { get; set; }
        public int Qunaity { get; set; }
        public float Price { get; set; }
        public String Description { get; set; }
        public Category Category { get; set; }
        public List<Provider> Providers { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "\nDescription: " + Description + "\nPrice:" + Price + "\nDatetime: "
                + DateProduction + "\nQuantity: " +
                Qunaity;
        }
        public virtual void GetMyType()
        {
            Console.WriteLine( "je suis un produit" );
        }
    }
}


