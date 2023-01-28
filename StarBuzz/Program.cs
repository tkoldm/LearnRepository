// See https://aka.ms/new-console-template for more information

using StarBuzz;
using StarBuzz.Abstractions;
using StarBuzz.Implementations.Beverages;
using StarBuzz.Implementations.Decorators;

Beverage espresso = new Espresso();
espresso = new Mocha(espresso);
espresso  = new Whip(espresso);
Console.WriteLine($"{espresso.GetDescription()} cost {espresso.GetCost()} $");

Beverage darkRoast = new DarkRoast();
darkRoast = new Mocha(darkRoast);
darkRoast  = new Whip(darkRoast);
Console.WriteLine($"{darkRoast.GetDescription()} cost {darkRoast.GetCost()} $");
darkRoast.SetSize(Size.VENTI);
Console.WriteLine($"{darkRoast.GetDescription()} cost {darkRoast.GetCost()} $");


Beverage houseBlend = new HouseBlend();
houseBlend = new Soy(houseBlend);
Console.WriteLine($"{houseBlend.GetDescription()} cost {houseBlend.GetCost()} $");
houseBlend.SetSize(Size.VENTI);
Console.WriteLine($"{houseBlend.GetDescription()} cost {houseBlend.GetCost()} $");