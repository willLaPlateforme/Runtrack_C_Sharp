public class Program
{
    static void Main(string [] args)
    {
        Wolf w1= new Wolf("Fenrir", 50, 25);
        Wolf w2= new Wolf ("Luna");

        Console.WriteLine($"Le nom de ce loup est {w1.Name}, ses points de vie sont de {w1.Health} et ses dégâts sont de {w1.Damage}");
        Console.WriteLine($"Le nom de cette louve est {w2.Name}, ses points de vie sont de {w2.Health} et ses dégâts sont de {w2.Damage}");
    }
}