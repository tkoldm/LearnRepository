using StarBuzz.Abstractions;

namespace StarBuzz.Implementations.Decorators;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) : base(beverage)
    {
    }

    public override void SetSize(Size size)
    {
        Beverage.SetSize(size);
    }

    public override string GetDescription() => Beverage.GetDescription() + ", Whip";

    public override double GetCost() => Beverage.GetCost() + 0.13 * (double)Beverage.GetSize();
}