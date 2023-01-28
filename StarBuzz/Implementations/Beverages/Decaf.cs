using StarBuzz.Abstractions;

namespace StarBuzz.Implementations.Beverages;

public class Decaf : Beverage
{
    public Decaf()
    {
        Description = "Decaf";
        BaseCost = 1.5;
    }

    public override void SetSize(Size size)
    {
        Size = size;
    }

    public override string GetDescription() => Description;

    public override double GetCost()
    {
        return (double)GetSize() * BaseCost;
    }
}