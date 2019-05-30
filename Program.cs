using System;

namespace urbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            City megalopolis = new City("Megaloplis");

            //Create several buildings in the Main() method of Program.cs.
            //Give each building a width, height, and number of stories.
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 25.5,
                height = 10.1,
                Stories = 5
            };
            Building NSS = new Building("500 Interstate Blvd")
            {
                Width = 45.5,
                height = 20.1,
                Stories = 4
            };
            Building BellHouse = new Building("100 main street")
            {
                Width = 32.5,
                height = 18.1,
                Stories = 5
            };

            //Add Building to city
            megalopolis.AddBuilding(FiveOneTwoEigth);
            megalopolis.AddBuilding(NSS);
            megalopolis.AddBuilding(BellHouse);
            //Construct each building.
            FiveOneTwoEigth.construct();
            NSS.construct();
            BellHouse.construct();
            //Have business people in your city purchase each of your buildings.
            FiveOneTwoEigth.Purchase("David Roller");
            NSS.Purchase("John Worker");
            BellHouse.Purchase("Ali Abdulle");

            foreach (Building building in megalopolis.buildings)
            {
                building.DisplayInformation();
            }
        }

    }
}
