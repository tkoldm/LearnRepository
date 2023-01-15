using SimUDuck.Absractions;

namespace SimUDuck.Implementations;

public class QuackMute : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("*Silence*");
    }
}