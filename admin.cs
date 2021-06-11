using System;

namespace ConsoleApp3
{
    // Class Human - describes a person
    class Admin //Citizen
    {
        
        protected string name; 
        protected string surname;
        protected string position;
        protected bool sex;

        // 2. Constructor with 3 parameters
        public Admin(string _name, string _surname, string _position, bool _sex)
        {
            name = _name;
            surname = _surname;
            position = _position;
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
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public void Print()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("surname: {0}", surname);
            Console.WriteLine("Position: {0}", position);
            if (sex)
                Console.WriteLine("sex: Female");
            else
                Console.WriteLine("sex: Male");
        }
    }
}