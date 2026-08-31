public class Fonction
{
    public static void Identify(int niveau)
    {
        if (niveau == 0)
        Console.WriteLine($"le niveau est égale à {niveau}");

        else if (niveau == 1)
        Console.WriteLine($"le niveau est égale à {niveau}");

        else if (niveau >=2 && niveau <= 4)
        Console.WriteLine($"Le niveau est compris entre 2 et 4");

        else
        Console.WriteLine($"le niveau est égale voir supérieur à cinq");
    }
}