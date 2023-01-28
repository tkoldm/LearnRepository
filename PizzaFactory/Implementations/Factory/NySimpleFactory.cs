using PizzaProblem.Abstractions;
using PizzaProblem.Implementations.Pizzas;

namespace PizzaProblem.Implementations.Factory;

public class NySimpleFactory : SimplePizzaFactory
{
    public override Pizza CreatePizza(string type)
    {
        Pizza pizza = type switch
        {
            "cheese" => new NyCheesePizza(),
            "pepperoni" => new NyPepperoniPizza(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), "Unknown pizza type")
        };

        return pizza;
    }
}