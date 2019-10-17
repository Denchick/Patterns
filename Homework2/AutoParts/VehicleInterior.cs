namespace Homework2.AutoParts
{
    public interface IVehicleInterior
    {
        string Name { get; }
    }

    public class VeloursInterior: IVehicleInterior
    {
        public string Name => "Braun Velours";
    }

    public class LeatherInterior: IVehicleInterior
    {
        public string Name => "Black Leather";
    }
}
