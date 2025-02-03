using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GP.Domain
{
    public class Provider
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        private String password;
        public String Password
        {
            get { return password; }
            set {
                if(value.Length >= 5 && value.Length <= 20)

                    password = value;
            else
                    Console.WriteLine("le password doit etre entre 5 et 20");

            } 
        }
            
   


        public bool IsApproved { get; set; }
        //public String ConfirmPassword { get; set; }
        private String confirmpassword;
        public String ConfirmPassword
        {
            get { return confirmpassword; }
            set
            {
                if (value.Equals(Password))

                    confirmpassword = value;
                else
                    Console.WriteLine("le password doit etre identiques");

            }
        }
        public String Email { get; set; }

        public DateTime DateCreate { get; set; }
        public List<Product> Products { get; set; }
        public override string ToString()
        {
            return "userName: " + UserName + "\nPassword: " + Password;
        }

        //polymophism
        public Boolean Login(String noUser, String passwordUser)
        {

            return (String.Compare(UserName, noUser) == 0 && String.Compare(passwordUser, password) == 0);

        }
        public Boolean Login(String noUser, String passwordUser, String mailUser)
        {

            return (String.Compare(UserName, noUser) == 0 && String.Compare(passwordUser, password) == 0 && String.Compare(mailUser, Email) == 0);

        }

        public static void SetIsApproved(Provider p)
        {

            p.IsApproved=String.Compare(p.password, p.confirmpassword) == 0;
               
        }
        


        public static void SetIsApproved(String p, String cf , bool Ia)
        {

            Ia = String.Compare(p, cf) == 0;

        }




    }
}
