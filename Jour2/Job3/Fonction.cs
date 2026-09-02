public class MerchantCart
{
    private double gold;

    public double Gold => gold;

    public void AddGold(double amount)
    {
        gold = gold + amount;
    }

    public bool PayFee(double amount)
    {
        if (amount> gold)
        {
            Console.WriteLine($"Alerte le retrait à était refusé, solde insuffisant.");
            return false;
        }
        else
        {
            gold = gold - amount;
            return true;
        }
    }
}