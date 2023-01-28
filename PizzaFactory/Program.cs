// See https://aka.ms/new-console-template for more information
using PizzaProblem.Implementations.PizzaStores;

var pizzaStore = new NyPizzaStore();

var pepperoniPizza = pizzaStore.OrderPizza("pepperoni");
Console.WriteLine("Pepperoni pizza is done!");

var cheesePizza = pizzaStore.OrderPizza("cheese");
Console.WriteLine("Cheese pizza is done!");

try
{
    var unknownPizza = pizzaStore.OrderPizza("unknown"); 
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}