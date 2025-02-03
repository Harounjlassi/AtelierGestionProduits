using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;


namespace GP.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Name = "Test";
            p.DateProduction = new DateTime(2025,02,02);
            Product p2 = new Product("pommme", "ddsdfedf", 12.3f, DateTime.Now, 16);
            Product p3 = new Product {
                Name="bananas", 
                Description="ddsdfedf",
                
            };


            System.Console.WriteLine("Liste de Products ");
            System.Console.WriteLine(p2);

            Provider pr= new Provider
            {
                UserName="pr1",
                Password="acccbc",
                ConfirmPassword= "acccbc"
            };
            System.Console.WriteLine(pr);
            System.Console.WriteLine(pr.Login("prs1", "acccbc"));

            Biological b = new Biological();
            Chemical c = new Chemical();
            b.GetMyType();
            c.GetMyType();

            //passge par reference
            //Provider.SetIsApproved(pr);

            //passage par valeur :la : IsApproved ne chage pas  
            Provider.SetIsApproved(pr.Password,pr.ConfirmPassword,pr.IsApproved);
            System.Console.WriteLine(pr.IsApproved);
                

            System.Console.ReadKey();
        }
    }
}
