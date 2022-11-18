using Tasks2IFlyable.Intefaces;
using Tasks2IFlyable.Structs;

namespace Tasks2IFlyable.Classes
{
    internal class Bird : FlyingObject
    {
        private uint _speed;

        /// <summary>
        /// Максимальная скорость полета птицы
        /// </summary>
        public uint MaxSpeed { get; set; }

        public override void FlyTo(Coords coords) { }

        public override double GetFlyTime(Coords coords) { return 0; }

        public Bird(uint speed)
        {
            _speed = speed;
        }
    }
}
