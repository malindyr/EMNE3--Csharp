
 public class GameCharacter
{
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Stamina { get; set; }
    public GameCharacter(int health, int strength, int stamina)
    {
        Health = health;
        Strength = Random.Next(1 - 31);
        //Strength = strength;
        Stamina = stamina;
     }

    public void Fight()
    {
      

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
    public Creeper() : base(100, strength, 100) { }
}