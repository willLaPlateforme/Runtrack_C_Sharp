public class Fonction
{
    public static void Communicate(string message)
    {
        Console.WriteLine(message);
    }

    public static void DisplayInfo()
    {
        string Name= "Test";
        int age = 20;
        int Niveau = 40;
        string Classe = "Guerrier";
        double NombreDePiecesDOr = 100000;
        bool nouveau = false;

        Console.WriteLine($"Le nom est {Name}");
        Console.WriteLine($"L'age est de {age}");
        Console.WriteLine($"Le niveau est de {Niveau}");
        Console.WriteLine($"La classe choisit est {Classe}");
        Console.WriteLine($"Le nombre de pieces est de : {NombreDePiecesDOr}");
        Console.WriteLine($"Est nouveau ? {nouveau}");
    }
    
}