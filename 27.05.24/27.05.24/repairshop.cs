using System.Net.Http.Headers;

class RepairShop
{

    public Mechanic Mechanic { get; private set; }

    public List<Car> Cars { get; private set; } 

    public RepairShop(Mechanic mechanic)
    {
        Mechanic = mechanic;
        Cars = new List<Car>()
        {
            new Car("Kåre", new Breaks(true), new Engine(false)),
            new Car("Georg", new Breaks(false), new Engine(true)),
            new Car("Trine", new Breaks(false), new Engine(true)),
        };
    }

    public void WorkDay()
    {
       foreach (Car car in Cars)
        {
            newArrival(car);
        }
    }
 
    public void newArrival(Car car)
    {
        Console.WriteLine(car.Owner);
        Mechanic.AssignCar(car);
        pickUpFixedCar(car);
    }

    public void pickUpFixedCar(Car car)
    {
        Console.WriteLine($"{car.Owner}'s car has been fixed, is now driving out of the repair shop and into the sunset");
    }

}