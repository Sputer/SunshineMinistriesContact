using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineMinistriesContact.Data_Acess_Layer
{
    public class User
    {
        //properties
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccessLevel { get; set; }


        //constructors
        public User()
        {

        }

        public User(string id, string firstName, string lastName, string phoneNumber, string userName, string password, string accessLevel)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.UserName = userName;
            this.Password = password;
            this.AccessLevel = accessLevel;
        }
    }
}
