using System;

namespace CustomerSearch.Class
{
    public abstract class Customer
    {

        public string country { get; set; }
        public string company { get; set; }
        public string contact { get; set; }

        public Customer()
        {
            
        }

        public Customer(string country, string company, string contact)
        {   
            this.country = country;
            this.company = company;
            this.contact = contact;
        }

        public abstract void SearchbyCountry(string country);
        public abstract void SearchbyCompany(string company);
        public abstract void SearchbyContact(string contact);
                
    }
}
