namespace StarBuzz.Abstractions;

public abstract class Beverage
{
    private protected string Description = "Base beverage";
    private protected Size Size = Size.TALL;
    private protected double BaseCost;

    public abstract void SetSize(Size size);

    public Size GetSize() => Size;
    
    public abstract string GetDescription();

    public abstract double GetCost();
}