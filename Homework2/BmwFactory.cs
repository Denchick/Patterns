using Homework2.AutoParts;

namespace Homework2
{
    public class BmwFactory: IAutoFactory
    {
        public IEngine CreateEngine() => new DohcEngine();

        public IHeadlights CreateHeadlights() => new HalogenHeadlights();

        public ISteeringWheel CreateSteeringWheel() => new BmwSteeringWheel();

        public IVehicleInterior CreateVehicleInterior() => new VeloursInterior();
    }
}
