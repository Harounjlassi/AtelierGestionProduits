using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        }
    }
}
