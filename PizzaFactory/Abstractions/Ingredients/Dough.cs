namespace PizzaProblem.Abstractions.Ingredients;

public abstract class Dough : IIngredient
{
    private protected string Description;

    public string GetDescription() => Description;
}