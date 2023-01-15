using SimUDuck.Absractions;

namespace SimUDuck.Implementations.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck(
        )
    {
        _flyBehavior = new FlyWithWings();
        _quackBehavior = new QuackRegular();
    }
    public override void Display()
    {
        Console.WriteLine("I'm Mallard");
    }
}