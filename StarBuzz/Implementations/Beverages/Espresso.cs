using StarBuzz.Abstractions;

namespace StarBuzz.Implementations.Beverages;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
        BaseCost = 0.5;
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