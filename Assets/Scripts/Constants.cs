public static class Constants
{
    /// Items
    
    // Drug
    public static readonly Item catnip = new Item("Catnip", "An herb that contain nepetalactone.");

    // Consumable
    public static readonly Item milk = new Item("Milk", "Don't forget that cat people have lactose intolerance.");
    public static readonly Item water = new Item("Water", "Fresh water to quench your thirst.");
    public static readonly Item meat = new Item("Meat", "Juicy meat.");

    // Other
    public static readonly Item wood = new Item("Wood", "Basic material for all kind of construction.");
    public static readonly Item iron = new Item("Iron", "Basic material for construction of most weapons.");


    public const int startMoney = 1000;
    public static readonly Item[] startItems = new Item[] { water, water, water, meat, meat };
}
