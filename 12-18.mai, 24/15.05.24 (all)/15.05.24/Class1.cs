using System;

public class People
{
    public string Name { get; set; }
    public int HealthyKidneys { get; set; }
    public bool IsAlive { get; set; }

    public People(string name, int healthyKidneys, bool isAlive)
    {
        Name = name;
        HealthyKidneys = healthyKidneys;
        IsAlive = isAlive;
    }
}

