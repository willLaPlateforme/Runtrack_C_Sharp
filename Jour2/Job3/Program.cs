public class Program
{
    static void Main(string[] args)
    {
        MerchantCart cart = new MerchantCart();
        cart.AddGold(15);
        bool result = cart.PayFee(50);

        Console.WriteLine($"Résultat de votre achat: {result}");
    }
}