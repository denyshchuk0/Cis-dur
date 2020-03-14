using System;
using System.Collections.Generic;
using System.Text;

namespace _03._09
{
    class House
    {
        private uint Basements { get; set; }
        private uint Walls { get; set; }
        private uint Doors { get; set; }
        private uint Windows { get; set; }
        private uint Roof { get; set; }

        public House(uint Basements, uint Walls, uint Doors, uint Windows, uint Roof)
        {
            this.Basements = Basements;
            this.Walls = Walls;
            this.Doors = Doors;
            this.Windows = Windows;
            this.Roof = Roof;
        }

        public void ShowHouse()
        {
            Console.WriteLine($"Basements: {this.Basements}\nWalls: {this.Walls}\nDoors: {this.Doors}\nWindows: {this.Windows}\nRoof: {this.Roof}");
        }
    }
}
