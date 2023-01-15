// See https://aka.ms/new-console-template for more information

using SimUDuck.Absractions;
using SimUDuck.Implementations;
using SimUDuck.Implementations.Ducks;

Duck mallard = new MallardDuck();
mallard.PerformFly();
mallard.PerformQuack();
mallard.Swim();

// strategy pattern example
mallard.SetFlyBehavior(new FlyRocketPowered());
mallard.SetQuackBehavior(new QuackMute());

mallard.PerformFly();
mallard.PerformQuack();