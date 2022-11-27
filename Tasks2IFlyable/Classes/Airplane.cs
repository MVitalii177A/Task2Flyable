using Tasks2IFlyable.Intefaces;
using Tasks2IFlyable.Structs;

namespace Tasks2IFlyable.Classes
{
    internal class Airplane : FlyingObject
    {
        private int _speedIncrement;
        private uint _distanse;
        private uint _speed;

        /// <summary>
        /// Максимальная высота полета самолета
        /// </summary>
        public uint MaxAltitude { get; set; }

        public override void FlyTo(Coords coords) { }

        public override double GetFlyTime(Coords coords) { return 0; }

        public Airplane(Coords initialCoords, int speedIncrement, uint distanse, uint speed)
            :base(initialCoords)
        {
            _speedIncrement = speedIncrement;
            _distanse = distanse;
            _speed = speed;
        }

    }
}
