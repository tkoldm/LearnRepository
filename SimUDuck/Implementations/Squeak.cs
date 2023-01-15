using SimUDuck.Absractions;

namespace SimUDuck.Implementations;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}