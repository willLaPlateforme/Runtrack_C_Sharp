public class Fonction
{
    public static void PlayerInformation()
    {
        Console.WriteLine("Veuillez entrez votre nom :");
        string Nom = Console.ReadLine()!;

        Console.WriteLine("Veuillez entrez votre niveau :");
        int niveau = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Veuillez entrez votre classe :");
        string classe = Console.ReadLine()!;

        Console.WriteLine($"Bienvenue {Nom}, {classe} de niveau {niveau}! Ouverture de la porte.");

    }
}