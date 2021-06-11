using System;

namespace ConsoleApp3
{
    class Program
{
        static void Main(string[] args)
        {
            // 1. Using an instance of the Human class
            Console.WriteLine("                                    Human                  ");
            Console.WriteLine("------------------------");
            Human hm = new Human("John", "Johnson", false);
            hm.Print();
            Console.WriteLine("------------------------");
            Human hma = new Human("Adam", "Masion", false);
            hma.Print();
            Console.WriteLine("------------------------");
            Human hmq = new Human("Marta", "Losian", true);
            hmq.Print();
            Console.WriteLine("------------------------");
            Human hmss = new Human("Jacyk", "Lakiwski", false);
            hmss.Print();
            Human hmh = new Human("Jana", "Nobelskaja", true);
            hmh.Print();
            // 2. Using an instance of the admin class
            Console.WriteLine("------------------------");
            Console.WriteLine("                                    Administator");
            Console.WriteLine("------------------------");
            Admin hmw = new Admin("John", "Johnson", "Administator", false);
            hmw.Print();
            Console.WriteLine("------------------------");
            Admin hmp = new Admin("Marta", "Losian", "Administator", true);
            hmp.Print();


            // 3. Using an instance of the Citizen class
            Console.WriteLine("------------------------");
            Console.WriteLine("                                    Citizen");
            Citizen ct = new Citizen("John", "Johnson", false, "A101ksdl233", "London");
            Console.WriteLine("------------------------");
            ct.Print();
            Citizen ctq = new Citizen("Adam", "Masion", false, "S621vkal260", "London");
            Console.WriteLine("------------------------");
            ctq.Print();
            Citizen ctw = new Citizen("Marta", "Losian", true, "X821lasl995", "London");
            Console.WriteLine("------------------------");
            ctw.Print();

            // display the value of the class fields

            // 4. Using an instance of the ForeignCitizen class
            Console.WriteLine("------------------------");

            Console.WriteLine("                                    Foreign Citizen");

            ForeignCitizen fc = new ForeignCitizen("Lakiwski", "Jacyk", false,
                  "JW3599301Q", "London", "023329032JJK",
                  Convert.ToDateTime("02.02.2020"), Convert.ToDateTime("03.03.2024"));
            Console.WriteLine("------------------");
            fc.Print();
            Console.WriteLine("------------------------");
            ForeignCitizen fca = new ForeignCitizen("Nobelskaja", "Jana", true,
               "SC3549300P", "Boston", "SWQ4153S241K",
               Convert.ToDateTime("12.09.2017"), Convert.ToDateTime("30.06.2021"));
            Console.WriteLine("------------------");
            fca.Print();
            Console.WriteLine("------------------------");
            // 5. Using an instance of the Flights class
            Console.WriteLine("                                    Flights");

            airlines air = new airlines("JW3599301Q", "London", "Boston",
                  Convert.ToDateTime("19.05.2021"), Convert.ToDateTime("20.05.2021"));
            Console.WriteLine("------------------------");
            air.Print();

            airlines airs = new airlines("SC3549300P", "Boston", "London",
                Convert.ToDateTime("21.05.2021"), Convert.ToDateTime("22.05.2021"));
            Console.WriteLine("------------------------");
            airs.Print();

            ConsoleColor color = Console.ForegroundColor;
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen; // display the list of commands in green
               Console.WriteLine("1. Administrators: \t 2. Information about flight:  \t 3. Visa information:");
               Console.WriteLine("4. Information about flights \t");
               Console.WriteLine("Enter the item number:");
               Console.ForegroundColor = color;
               try
               {
                   int command = Convert.ToInt32(Console.ReadLine());

                   switch (command) //writes us information when entering numbers in the console
                {
                       case 1:
                        Console.WriteLine("Josh Josh");//writes us information when entering numbers  in the console is "1"
                        Console.WriteLine("Marta Losian");
                        break;
                   }

                switch (command)
                {
                    case 2:
                        Console.WriteLine("From:London. To: Boston. Flight number: JW3599301Q. Date: 19.05.2021 - 20.05.2021 ");//writes us information when entering numbers in the console is "2"
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        Console.WriteLine("From:Boston. To: London. Flight number: SC3549300P. Date: 21.05.2021 - 22.05.2021");
                        break;
                }
                switch (command)
                {
                    case 3:
                        Console.WriteLine("Nobelskaja Jana - SWQ4153S241K, Visa: 12.09.2017 - 30.06.2021");//writes us information when entering numbers in the console is "3"
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("Jacyk Lakiwski - 023329032JJK, Visa: 02.02.2020 - 03.03.2024");
                        break;
                }
                switch (command)
                {
                    case 4://writes us information when entering numbers in the console is "4"
                        Console.WriteLine("Information about flight: 'London - Boston' - The plane will arrive on the 19th at 2 p.m.,check-in will take place from 1 p.m. to 1.30 p.m.");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Information about flight: 'Boston - London' - The plane will arrive on the 21th at 7 a.m.,check-in will take place from 6 a.m. to 6.30 a.m.");
                        break;
                }

            }
               catch (Exception ex)
               {
                // display the error message in red
                color = Console.ForegroundColor;
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine(ex.Message);
                   Console.ForegroundColor = color;
               }
        }

        }

}
