using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantProject_Core.Models
{
    public class Customer
    {
        public int ID
        {
            get;
            set;
        }
        public string FIRSTNAME;
        public string Lastname;
        public string Email;
        public bool Ismale;
        public DateTime Birthdate;
        public string phonenumber;
        public Adress address;
        public bool IsvalidEmail;      
        public DateTime CreatedDate;
    }
}
