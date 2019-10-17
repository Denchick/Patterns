using Homework2.AutoParts;

namespace Homework2
{
    public interface IAutoFactory
    {
        IEngine CreateEngine();

        IHeadlights CreateHeadlights();

        ISteeringWheel CreateSteeringWheel();

        IVehicleInterior CreateVehicleInterior();
        
        // etc.
    }
}
