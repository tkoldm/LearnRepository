using StarBuzz.Abstractions;

namespace StarBuzz.Implementations.Beverages;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast";
        BaseCost = 1;
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