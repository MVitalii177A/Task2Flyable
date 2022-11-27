using Tasks2IFlyable.Structs;

namespace Tasks2IFlyable.Classes
{
    internal class Drone : FlyingObject
    {
        private uint _delay;
        private uint _delayfrequency;

        /// <summary>
        /// Максимальная дистанция полета
        /// </summary>
        public uint MaxDistance { get; set; }

        public override void FlyTo(Coords coords) { }

        public override double GetFlyTime(Coords coords) { return 0; }

        public Drone(Coords initialCoords, uint delay, uint delayfrequency)
            :base(initialCoords)
        {
            _delay = delay;
            _delayfrequency = delayfrequency;
        }
    }
}
