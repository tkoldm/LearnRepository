namespace PizzaProblem.Abstractions.Ingredients;

public abstract class Cheese : IIngredient
{
    private protected string Description;

    public string GetDescription() => Description;
}