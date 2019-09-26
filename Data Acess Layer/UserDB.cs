using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineMinistriesContact.Data_Acess_Layer
{
    class UserDB
    {

        public static List<User> TestPopulate()
        {
            var test = new List<User>();
            test.Add(new User("1", "Chase", "Wille", "555-555-5555", "cwille", "password1", "Admin"));
            test.Add(new User("2", "Chris", "Kyle", "555-555-5556", "killerkyle", "sniper4life", "Basic"));
            test.Add(new User("3", "Gary", "Vaynerchek", "555-555-5557", "garyv", "motospeaker", "Full"));
            return test;
        }


        //Populate List

        //Create

        //Read

        //Update

        //Delete


    }
}
