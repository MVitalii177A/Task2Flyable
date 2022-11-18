using Tasks2IFlyable.Structs;

namespace Tasks2IFlyable.Intefaces
{
    internal interface IFlyable
    {
        void FlyTo(Coords coords);

        double GetFlyTime(Coords coords);
    }
}
