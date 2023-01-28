namespace StarBuzz.Abstractions;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage Beverage;

    protected CondimentDecorator(Beverage beverage)
    {
        this.Beverage = beverage;
    }
}