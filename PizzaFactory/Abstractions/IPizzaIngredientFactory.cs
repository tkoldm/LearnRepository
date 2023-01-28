using PizzaProblem.Abstractions.Ingredients;

namespace PizzaProblem.Abstractions;

public interface IPizzaIngredientFactory
{
    Dough CreateDough();
    Sauce CreateSauce();
    Cheese CreateCheese();
    Veggies[] CreateVeggies();
    Pepperoni CreatePepperoni();
}