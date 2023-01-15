using SimUDuck.Absractions;

namespace SimUDuck.Implementations;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("*Rocket powered fly*");
    }
}