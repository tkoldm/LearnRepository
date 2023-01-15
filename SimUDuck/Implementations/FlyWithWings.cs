using SimUDuck.Absractions;

namespace SimUDuck.Implementations;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("*The sound of flapping wings*");
    }
}