public static class Constants
{
    /// Items
    
    // Drug
    public static readonly Item catnip = new Item("Catnip", "An herb that contain nepetalactone.", 3000);

    // Consumable
    public static readonly Item milk = new Item("Milk", "Don't forget that cat people have lactose intolerance.", 300);
    public static readonly Item water = new Item("Water", "Fresh water to quench your thirst.", 100);
    public static readonly Item meat = new Item("Meat", "Juicy meat.", 150);

    // Other
    public static readonly Item wood = new Item("Wood", "Basic material for all kind of construction.", 400);
    public static readonly Item iron = new Item("Iron", "Basic material for construction of most weapons.", 1000);


    public const int startMoney = 2000;
    public static readonly Item[] startItems = new Item[] { water, water, water, meat, meat };
}
