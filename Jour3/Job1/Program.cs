//using System.Collections.Generic;
using Tartaros.Exploration;

class Program
{
    static void Main(string [] args)
    {
        GuildSupply guildSupply = new GuildSupply();
        guildSupply.ShowSupplies();
        guildSupply.UseSupply("Potion De Soin");
        guildSupply.ShowSupplies();
    }
}