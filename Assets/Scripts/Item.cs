public class Item
{
    public Item(string name, string description, int basePrice)
    {
        this.name = name;
        this.description = description;
    }

    public override string ToString()
    {
        return (name + ": " + description);
    }

    private readonly string name;
    private readonly string description;
    private readonly int basePrice;
}
