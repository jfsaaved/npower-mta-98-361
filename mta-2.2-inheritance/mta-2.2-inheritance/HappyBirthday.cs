using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mta_2._2_inheritance
{


    class HappyBirthday
    {

        private string birthdayMessage;
        private string presentString;


        public HappyBirthday()
        {
            presentString = "Number of presents: ";
            birthdayMessage = "Happy Birthday ";
        }

        public string getMessage(String givenName)
        {
            return birthdayMessage + givenName;
        }

        public string getPresents(int numPresents)
        {
            return presentString + numPresents.ToString();
        }
    }


}
