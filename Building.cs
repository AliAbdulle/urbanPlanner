using System;

namespace urbanPlanner
{
    class Building
    {
        private string _designer {get; set;}
        private DateTime _dateConstructed {get; set;}
        private string _address {get; set;}
        private string _owner {get; set;}
        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public double Valume 
        {
            get {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building (string address){
            _address = address;

        }
        public void construct() {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string purchaser) {
            _owner = purchaser;
        }
        public void DisplayInformation()
        {
            Console.WriteLine($"{_address}");
        }

    }
}