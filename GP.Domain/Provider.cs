using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Provider
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public bool IsApproved { get; set; }
        public String ConfirmPassword { get; set; }
        public String Email { get; set; }
        public DateTime DateCreate { get; set; }
        public List<Product> Products { get; set; }


    }
}
