namespace Homework2.AutoParts
{
    public interface IHeadlights
    {
        string Name { get; }
    }

    public class HalogenHeadlights : IHeadlights
    {
        public string Name => "Halogen headlights";
    }

    public class LedHeadlights : IHeadlights
    {
        public string Name => "LED headlights";
    }
}
