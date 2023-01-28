using PizzaProblem.Abstractions;

namespace PizzaProblem.Implementations.Factory;

public abstract class SimplePizzaFactory
{
    public abstract Pizza CreatePizza(string type);
}