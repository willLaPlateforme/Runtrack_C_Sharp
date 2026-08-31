public class Fonction
{
    public static void DisplayAventurer(string Name, int age, string classe, int niveau, double bourse, bool nouveau)
    {
        Console.WriteLine($"L'avanturier {Name}, un {classe} de {age} ans, est niveau {niveau} et a une bourse de {bourse} pièces d'or.");
        if (nouveau)
        {
            Console.WriteLine("Cet avanturier est nouveau.");
        }
        else
        {
            Console.WriteLine("Cet aventurier n'est pas nouveau.");
        }
    }
}