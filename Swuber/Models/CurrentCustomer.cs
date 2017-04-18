using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Swuber.Models
{
    public class CurrentCustomer
    {
       
        public String firstNameCC { get; set; }
        public String lastNameCC { get; set; }
        public String phoneCC { get; set; }
      

    public CurrentCustomer (String firstName, String lastName, String phone)
        {
           
            firstNameCC = firstName;
            lastNameCC = lastName;
            phoneCC = phone;
        }//end constructor
    }
    
}