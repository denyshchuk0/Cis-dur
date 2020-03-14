using System;

namespace _03._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Basement basement = new Basement(1);
            uint BasementCount = basement.PartsCount;

            Wall walls = new Wall(4);
            uint wallsCount = walls.PartsCount;

            Door doors = new Door(1);
            uint doorsCount = doors.PartsCount;

            Window windows = new Window(6);
            uint windowsCount = windows.PartsCount;

            Roof roofs = new Roof(3);
            uint roofsCount = roofs.PartsCount;

            House house = new House(BasementCount, wallsCount, doorsCount, windowsCount, roofsCount);
            house.ShowHouse();
        }
    }
}
