using System;

namespace ConsoleApp3
{
    // Class Human - describes a person
    class Human
    {
        // 1. Internal fields of the class
        protected string name; // Name
        protected string surname; // Second name
        protected bool sex; // Sex: true - female, false - man

        // 2. Constructor with 3 parameters
        public Human(string _name, string _surname, bool _sex)
        {
            name = _name;
            surname = _surname;
            sex = _sex;
        }

        // 3. Properties for accessing the internal fields of the class
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        // 4. Method Print () - displays the names of the class fields on the screen
        public void Print()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("surname: {0}", surname);
            if (sex)
                Console.WriteLine("sex: Female");
            else
                Console.WriteLine("sex: Male");
        }
    }
}