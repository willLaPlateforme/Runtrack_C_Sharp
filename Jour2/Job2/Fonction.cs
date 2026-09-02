public class Wolf
{
    public string Name { get; set; }
    public int Health { get; set; }

    public int Damage { get; set; }

    public Wolf(string Name, int Health, int Damage)
    {
        this.Name = Name;
        this.Health= Health;
        this.Damage= Damage; 
    }

    public Wolf (string Name)
    {
        this.Name= Name;
        this.Health= 20;
        this.Damage=5;
    }
}