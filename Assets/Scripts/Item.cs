public class Item
{
    /// <param name="name">Name of the item</param>
    public Item(string name, string description)
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
}
