 public class GameCharacter
{
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Stamina { get; set; }

    public GameCharacter(int health, int strength, int stamina)
    {
        Health = health;
        Strength = strength;
        Stamina = stamina;
    }


    public void Fight(GameCharacter opponent)
    {
        //Hver gang en character bruker metoden Fight() mister de også 10 stamina.
        if (Stamina > 0)
        {
            opponent.Health -= Strength;
            Stamina -= 10;
        }

    }

    public void Recharge()
    {

    }
}

 public class Steve : GameCharacter
{
     public Steve() : base(100, 100, 100) { }
}

public class Creeper : GameCharacter
{
    private static Random random = new Random();
    public Creeper() : base(100, random.Next(0,31), 100) { }

    public void RandomizeStrength()
    {
        Strength = random.Next(0,31);
    }


}