public class Order
{
    public PotionType Category { get; set; }
    public int Quantity { get; set; }
    
    public string? Instructions { get; set; }

    public Order(PotionType category, int quantity, string? instructions = null)
    {
        Category = category;
        Quantity = quantity;
        Instructions = instructions;
    }

    public void Display()
    {
        string instructionsText = Instructions ?? "Aucune instruction";
        Console.WriteLine($"Commande : {Quantity} potion(s) de {Category}");
        Console.WriteLine($"Instructions : {instructionsText}");
    }
}