using System;

namespace ConsoleApp3
{
    
    sealed class airlines
    {
        // 1. Internal fields of the class
        private string internationalflight; // Number of flight
        private string flightfrom;
        private string flightto;
        private DateTime landingOpen; // boarding opening date
        private DateTime landingClose; // boarding closing date

        // 2. Constructor with 5 parametersr
        public airlines(string _internationalflight, string _flightfrom,string _flightto, DateTime _landingOpen, DateTime _landingClose)
        {
            internationalflight = _internationalflight;
            landingOpen = _landingOpen;
            landingClose = _landingClose;
            flightfrom = _flightfrom;
            flightto = _flightto;
        }

        // 3. Properties for accessing the internal fields of the class

        public string Internationalflight
        {
            get { return internationalflight; }
            set { internationalflight = value; }
        }

        public string Flightfrom
        {
            get { return flightfrom; }
            set { flightfrom = value; }
        }

        public string Flightto
        {
            get { return flightto; }
            set { flightto = value; }
        }
       
        public DateTime LandingOpen
        {
            get { return landingOpen; }
            set { landingOpen = value; }
        }

        public DateTime LandingClose
        {
            get { return landingClose; }
            set { landingClose = value; }
        }

        // 4. Method Print () - output of class fields

        public void Print()
        {
            Console.WriteLine("internationalflight: {0}", internationalflight);
            Console.WriteLine("landingOpen: {0}", landingOpen);
            Console.WriteLine("landingClose: {0}", landingClose);
            Console.WriteLine("Flight from: {0}", flightfrom);
            Console.WriteLine("Flight to: {0}", flightto);
        }
    }
}