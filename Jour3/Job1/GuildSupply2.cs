//using System.Collections.Generic;
namespace Tartaros.Exploration
{
    public partial class GuildSupply
    {
        public void ShowSupplies()
        {

            Console.WriteLine($"Voici les items présents :");
            foreach (string itemnames in Supplies)
            {
                Console.WriteLine(itemnames);
            }

        }

        public void UseSupply(string itemnames)
        {
            Supplies.Remove(itemnames);
            Console.WriteLine($"{itemnames} a été utilisé.");
            
        }
    }
}