public class Fonction
{
    public static void DisplayInfo()
    {
        string Name = "Test";
        int age = 20;
        int Niveau = 40;
        string Classe = "guerrier";
        double NombreDePiecesDOr= 100000;
        bool nouveau = false;

        Console.WriteLine($"le nom est {Name}");
        Console.WriteLine($"l'age est {age}");
        Console.WriteLine($"le niveau est {Niveau}");
        Console.WriteLine($"la Classe est {Classe}");
        Console.WriteLine($"le nombre de pieces d_or est {NombreDePiecesDOr}");
        Console.WriteLine($"est nouveau ? {nouveau}");
    }
}