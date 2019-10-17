using Homework2.AutoParts;

namespace Homework2
{
    public class AudiFactory : IAutoFactory
    {
        public IEngine CreateEngine() => new I3Engine();

        public IHeadlights CreateHeadlights() => new LedHeadlights();

        public ISteeringWheel CreateSteeringWheel() => new AudiSteeringWheel();

        public IVehicleInterior CreateVehicleInterior() => new LeatherInterior();
    }
}
