using System;

namespace  ConsoleApp3

{
    // Citizen class - inherited from Human class
    class Citizen : Human
    {
        // 1. Internal fields of the class
        protected string password; // Passport ID
        protected string address; // Address of residence

        // 2. Class constructor - calls the base class constructor
        public Citizen(string _name, string _surname, bool _sex,
            string _password, string _address) : base(_name, _surname, _sex)
        {
            password = _password;
            address = _address;
        }

        // 3. Properties of access to class fields
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // 4. The method that retrieves the values of the class fields
        public new void Print()
        {
            base.Print(); // call the base class method
            Console.WriteLine("password: {0}", password);
            Console.WriteLine("address: {0}", address);
        }
    }
}