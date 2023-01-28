Simple example of strategy pattern from Chapter 1. 

We can set any fly or quack implementation with methods:
<li> SetFlyBehavior() </li>
<li> SetQuackBehavior() </li>
With this methods we can change duck behavior in run time.
For this code 

```csharp
Duck mallard = new MallardDuck();
mallard.PerformFly();
mallard.PerformQuack();
mallard.Swim();
```

Console output will look like this:

```text
*The sound of flapping wings*
Quack!
I'm swimming
```

Then if we set new instance of implementation IFlyBehavior and IQuackBehavior:

```csharp
mallard.SetFlyBehavior(new FlyRocketPowered());
mallard.SetQuackBehavior(new QuackMute());

mallard.PerformFly();
mallard.PerformQuack();
```

console output will be:

```text
*Rocket powered fly*
*Silence*
```

With this pattern we can avoid problems with future support when we need to add new behavior for new implementations of base class.
The main essence of pattern **strategy** - possibility to change object behavior in run time.