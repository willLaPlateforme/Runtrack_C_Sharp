//using System.Collections.Generic;
namespace Tartaros.Exploration
{
    public partial class GuildSupply
    {
        public List<string> Supplies { get; set;}

        public GuildSupply()
        {
            Supplies = new List<string> { "Potion De Soin", "Potion de Mana", "Potion d'endurance"};
        }
    }
}