using StarBuzz.Abstractions;

namespace StarBuzz.Implementations.Decorators;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) : base(beverage)
    {
    }

    public override void SetSize(Size size)
    {
        Beverage.SetSize(size);
    }

    public override string GetDescription() => Beverage.GetDescription() + ", Soy";

    public override double GetCost() => Beverage.GetCost() + 0.2 * (double)Beverage.GetSize();
}