using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mta_1._2_classes_and_object_first_class
{
    class HappyBirthday
    {
        public string getMessage(String name)
        {
            return "Happy Birthday " + name + "!";
        }

        private string birthdayMessage;

        public String MyProperty
        {
            get { return birthdayMessage; }
            set { birthdayMessage = value; }
        }



    }
}
