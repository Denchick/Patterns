namespace Homework6
{
    public interface IBanknote
    {
        CurrencyType Type { get; }
        uint Value { get; }
    }
}