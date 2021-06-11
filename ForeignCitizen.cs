using System;

namespace ConsoleApp3
{
    // ForeignCitizen class - inherited from Citizen class.
    // This class is sealed - it cannot be inherited by another class
    class ForeignCitizen : Citizen
    {
        // 1. Internal fields of the class
        private string foreignPassport; // foreign passport number
        private DateTime visaOpen; // visa opening date
        private DateTime visaClose; // visa closing date

        // 2. Class constructor - calls the base class constructor
        public ForeignCitizen(string _name, string _surname, bool _sex,
          string _password, string _address,
          string _foreignPassport, DateTime _visaOpen, DateTime _visaClose)
          : base(_name, _surname, _sex, _password, _address)
        {
            foreignPassport = _foreignPassport;
            visaOpen = _visaOpen;
            visaClose = _visaClose;
        }

        // 3. Properties for access to class fields
        public string ForeignPassport
        {
            get { return foreignPassport; }
            set { foreignPassport = value; }
        }

        public DateTime VisaOpen
        {
            get { return visaOpen; }
            set { visaOpen = value; }
        }

        public DateTime VisaClose
        {
            get { return visaClose; }
            set { visaClose = value; }
        }

        // 4. Method Print () - output of class fields
        public new void Print()
        {
            base.Print(); // call the base class method
            Console.WriteLine("foreignPassport: {0}", foreignPassport);
            Console.WriteLine("visaOpen: {0}", visaOpen);
            Console.WriteLine("visaClose: {0}", visaClose);
        }
    }
}