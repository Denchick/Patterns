namespace Homework2.AutoParts
{
    public interface ISteeringWheel
    {
        string Name { get; }
    }

    public class AudiSteeringWheel: ISteeringWheel
    {
        public string Name => "Audi steering wheel";
    }

    public class BmwSteeringWheel: ISteeringWheel
    {
        public string Name => "BMW steering wheel";
    }
}
