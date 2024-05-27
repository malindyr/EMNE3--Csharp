class Mechanic
{
    public Car CurrentCar { get; private set; }

    public void AssignCar(Car car)
    {
        CurrentCar = car;
        inspectCar();
    }

    public void inspectCar()
    {
        if (CurrentCar.Breaks.IsFaulty|| CurrentCar.Engine.IsFaulty)
        {
            fixCar();
        }
        else
        {
            Console.WriteLine("car has no faults");
        } ;
    }

    public void fixCar()
    {
        Console.WriteLine($"Car owned by {CurrentCar.Owner} is being repaired...");

        while (CurrentCar.Breaks.IsFaulty || CurrentCar.Engine.IsFaulty)
        {

            if (CurrentCar.Breaks.IsFaulty)
            {
                Console.WriteLine("fixing breaks...");
                CurrentCar.Breaks.BreakChange();
            }
            else if (CurrentCar.Engine.IsFaulty)
            {
                Console.WriteLine("fixing engine...");
                CurrentCar.Engine.EngineChange();
            }
        }

        Console.WriteLine($"Car owned by {CurrentCar.Owner} is now fixed and can be picked up by the owner.");
    }


}