using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;

namespace Services
{
    public class ServiceProduct
    {
        public List<Product> Products = new List<Product>();
        public Func<String, List<Product>> FindProduct;
        public Action<Category> ScanProduct;


        public ServiceProduct()
        {
            FindProduct = c =>
            {
                List<Product> lst = new List<Product>();
                foreach (Product p in Products)
                {
                    if (p.Name.StartsWith(c))
                    {
                        lst.Add(p);
                    }

                }
                return lst;

            };

            //FindProduct = c => Products.Where(p => p.Name.StartsWith(c)).ToList();

            ScanProduct = ca => {
                List<String> lsp = Products.Where(p => p.Category.CategoryId == ca.CategoryId)
                .OrderByDescending(p => p.Price)
                .Select(p=>p.Name).ToList();
                 foreach (String p in lsp)
                {
                    Console.WriteLine(p);

                }
            };


        }

    }
}