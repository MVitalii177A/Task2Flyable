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

            Bird bird = new Bird(new Coords(10, 20, 30), randomSpeed);
            bird.MaxSpeed = 35;

            Airplane airplane = new Airplane(new Coords(15, 25, 35), 10, 10, 200);
            airplane.MaxAltitude = 12000;

            Drone drone = new Drone(new Coords(23, 17, 18), 1, 10);
            drone.MaxDistance = 1000;

        }
    }
}