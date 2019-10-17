namespace Homework2.AutoParts
{
    public interface IEngine
    {
        string Name { get; }
    }

    public class DohcEngine: IEngine
    {
        public string Name => "DOHC FSI V10";
    }

    public class I3Engine: IEngine
    {
        public string Name => "I3 turbo B38A15T0";
    }
}
