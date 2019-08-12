namespace mta_2._2_inheritance {

    class BirthdayParty : HappyBirthday {

        public BirthdayParty() :base() {

        }
        
        public string getParty(bool haveParty) {
            if (haveParty)
                return "Enjoy your party!";
            else
                return "Sorry - no party for you.";
        }

        public string getParty(bool haveParty, string name) {
            if (haveParty)
                return "Enjoy your party! " + name;
            else
                return "Sorry - no party for you. " + name;
        }

        public string getParty(string name) {
            return "Enjoy your party! " + name;
        }

    }
}
