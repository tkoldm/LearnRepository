using SimUDuck.Absractions;

namespace SimUDuck.Implementations;

public class QuackRegular : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack!");
    }
}