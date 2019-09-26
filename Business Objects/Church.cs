
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineMinistriesContact.Data_Acess_Layer
{
    public class Church
    {
        //properties
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



        //constructors
        public Church()
        {

        }

        public Church(string id, string firstName, string lastName, string address)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address1 = address;
        }
    }
}
