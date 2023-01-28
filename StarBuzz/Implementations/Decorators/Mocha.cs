using StarBuzz.Abstractions;

namespace StarBuzz.Implementations.Decorators;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage)
    {
    }

    public override void SetSize(Size size)
    {
        Beverage.SetSize(size);
    }

    public override string GetDescription() =>
        Beverage.GetDescription() + ", Mocha";

    public override double GetCost() => Beverage.GetCost() + 0.32 * (double)Beverage.GetSize();
}