using System;
using System.Collections.Generic;

namespace urbanPlanner
{
    class City
    {
        //Name of the city.
        private string _name { get; set; }
        //The mayor of the city.
        private string _mayor { get; set; }
        //Year the city was established.
        private DateTime _establish { get; set; }
        //A collection of all of the buildings in the city.
        private List<Building> _buildings = new List<Building>();
        public List<Building> buildings
        {
            get
            {
                return _buildings;
            }
            set
            {
                buildings = buildings;
            }
        }

        //A method to add a building to the city.
        public void AddBuilding(Building building)
        {
            _buildings.Add(building);
        }
        public City(string name)
        {
            _establish = DateTime.Now;
            _name = name;
        }

    }
}