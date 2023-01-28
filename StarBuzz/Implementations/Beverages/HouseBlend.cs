using StarBuzz.Abstractions;

namespace StarBuzz.Implementations.Beverages;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend";
        BaseCost = 0.4;
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