using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineMinistriesContact.Data_Acess_Layer
{
    public class Individual
    {
        //properties for the individual object, use all strings for our properties for simplification, can be changed later
        // if we find a better use
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string City1 { get; set; }
        public string ZipCode1 { get; set; }
        public string State1 { get; set; }
        public string Address2 { get; set; }
        public string City2 { get; set; }
        public string ZipCode2 { get; set; }
        public string State2 { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneCell { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string WebsiteURL { get; set; }
        public string SocialMediaURL { get; set; }
        public string Source { get; set; }




        //constructor for the individual object. One must be empty to create a blank instance of the object, which we may need
        // for getting info from the DB

        public Individual()
        {

        }

        //next constructor contains the full list of properties being populated from the incoming parameters
        public Individual(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;

        }

    }
}
