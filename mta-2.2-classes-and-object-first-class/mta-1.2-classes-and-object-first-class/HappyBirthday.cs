using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mta_1._2_classes_and_object_first_class
{
    class HappyBirthday
    { 

        private string birthdayMessage;
        private int numberOfPresents;
        private bool isHavingBirthday;

        public HappyBirthday()
        {
            numberOfPresents = 0;
            isHavingBirthday = false;
        }
 
        public int PresentCount
        {
            set { numberOfPresents = value; }
        }

        public string getMessage(String name)
        {
            string message = "";
            message = "Happy Birthday " + name + "!\n";
            message += "Number of presents=" + numberOfPresents.ToString() + "\n";

            if (isHavingBirthday)
                message += "Hope you enjoy the party!";
            else
                message += "No party - Sorry!";

            return message;
        }

        public void checkIfBirthday(DateTime dateTime)
        {
            if (dateTime.Day == DateTime.Today.Day && dateTime.Month == DateTime.Today.Month)
                isHavingBirthday = true;
        }

        public String MyProperty
        {
            get { return birthdayMessage; }
            set { birthdayMessage = value; }
        }



    }
}
