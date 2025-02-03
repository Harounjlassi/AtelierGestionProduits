using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GP.Domain;

namespace Services
{
    public class ServiceProvider
    {
         public List<Provider> lsp;
        public List<Product> lsProduct;


        public IEnumerable<String> GetProiderByName(String name)
        {
            return from provider in lsp
                   where provider.UserName.Contains(name)
                   select provider.UserName;

        }
        public Provider GetFirstProiderByName(String name)

        {
       /*     var p= from provider in lsp
                   where provider.UserName.Contains(name)
                   orderby provider.UserName
                   select provider.UserName;
            return p;*/

            var p = from provider in lsp
                    where provider.UserName.Contains(name)
                    select provider;

            return p.FirstOrDefault();

        }


        public Provider GetProiderById(int id)

        {


            var p = from provider in lsp
                    where provider.Id.Equals(id)
                    select provider;

            return p.FirstOrDefault();
        }
        public IEnumerable<Product> Get5Chemical(double price) {
            var p = from product in lsProduct
                    where product.Price>price
                    select product;
            
            return p.Take(5);



        }
    }
}