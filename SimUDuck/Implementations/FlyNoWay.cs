using SimUDuck.Absractions;

namespace SimUDuck.Implementations;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("*Silence*");
    }
}