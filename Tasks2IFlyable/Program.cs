using System;
using Tasks2IFlyable.Classes;
using Tasks2IFlyable.Structs;

namespace Tasks2IFlyable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(20);
            uint randomSpeed = (uint)random.Next();


            Bird bird = new Bird(randomSpeed);
            bird.MaxSpeed = 35;
            bird.CurrentPosition = new Coords(10, 20, 30);

            Airplane airplane = new Airplane(10, 10, 200);
            airplane.MaxAltitude = 12000;
            airplane.CurrentPosition = new Coords(15, 25, 35);

            Drone drone = new Drone(1, 10);
            drone.MaxDistance = 1000;
            drone.CurrentPosition = new Coords(23, 17, 18);

        }
    }
}