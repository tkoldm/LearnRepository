namespace PizzaProblem.Abstractions.Ingredients;

public abstract class Sauce : IIngredient
{
    private protected string Description;

    public string GetDescription() => Description;
}