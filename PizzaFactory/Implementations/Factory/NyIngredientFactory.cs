using PizzaProblem.Abstractions;
using PizzaProblem.Abstractions.Ingredients;
using PizzaProblem.Implementations.Ingredients;
using PizzaProblem.Implementations.Ingredients.Vegetables;

namespace PizzaProblem.Implementations.Factory;

public class NyIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough() => new ThinCrustDough();

    public Sauce CreateSauce() => new MarinaraSauce();

    public Cheese CreateCheese() => new ReggianoCheese();

    public Veggies[] CreateVeggies() => new Veggies[] { new Garlic(), new Onion(), new Tomato() };

    public Pepperoni CreatePepperoni() => new SlicedPepperoni();
}