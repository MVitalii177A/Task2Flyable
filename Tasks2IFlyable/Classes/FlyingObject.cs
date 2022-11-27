using Tasks2IFlyable.Intefaces;
using Tasks2IFlyable.Structs;

namespace Tasks2IFlyable.Classes
{
    internal abstract class FlyingObject : IFlyable
    {
        public Coords CurrentPosition { get; set; }

        public abstract void FlyTo(Coords coords);

        public abstract double GetFlyTime(Coords coords);

        public FlyingObject(Coords initialPosition)
        {
            CurrentPosition = initialPosition;
        }
    }
}
