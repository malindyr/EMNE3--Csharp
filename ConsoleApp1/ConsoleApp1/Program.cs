
/*Bilforhandleren
En bilforhandler har ulike biler i shappa si,
det kan være biler med ulike merker, årsmodell, 
registreringsnummer og kilometerstand. 

Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa, 

eller han kan velge å finne en bil ut fra årsrange, 
eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand. Kunden skal også ha mulighet til å kjøpe en av bilene. 
Bilen må da tilhøre kunden og ikke forhandleren.*/


    CarShop shop = new CarShop();

    shop.AddCar(new Car("toyota", 2008, "MS64827", 100000));
    shop.AddCar(new Car("Audi", 2015, "GO63528", 150000));
    shop.AddCar(new Car("Kia", 2010, "YU64639", 40000));

while (true)
{
    Console.WriteLine("press 1 to show all cars \r\n press 2 to seach by year model \r\n press 3 to search by km \r\n press 4 to buy a car \r\n press 5 to exit");

    string answer = Console.ReadLine();

    HandleAnswer(answer);

    void HandleAnswer(string answer)
    {
        if (answer == "1")
        {
            shop.ShowAllCars();
        }
        else if (answer == "2")
        {
            FindCar();

        }
        else if (answer == "3")
        {
            FindCarKm();

        }
        else if (answer == "4")
        {
            PurchaseCar();
            //purchase car
        }
        else if(answer == "5")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("wrong input");
        }
    }

    void FindCar()
    {
        Console.WriteLine("enter year model from");
        var YearFrom = Convert.ToInt32((Console.ReadLine()));

        Console.WriteLine("enter year model to");
        var YearTo = Convert.ToInt32(Console.ReadLine());

        List<Car> SearchResult = new List<Car>();


        for (int i = 0; i < shop.Cars.Count; i++)
        {
            if (shop.Cars[i].YearModel >= YearFrom && shop.Cars[i].YearModel <= YearTo)
            {
                SearchResult.Add(shop.Cars[i]);
            }
        }

        foreach (var car in SearchResult)
        {
            Console.WriteLine($"Brand: {car.Brand} \r\n YearModel: {car.YearModel} \r\n Registration number: {car.RegNr} \r\n km: {car.Km}");
        }
    }

    void FindCarKm()
    {
        Console.WriteLine("enter minimum km distance");
        var KmFrom = Convert.ToInt32((Console.ReadLine()));

        Console.WriteLine("enter maximum km distance");
        var KmTo = Convert.ToInt32(Console.ReadLine());

        List<Car> SearchResult = new List<Car>();


        for (int i = 0; i < shop.Cars.Count; i++)
        {
            if (shop.Cars[i].Km >= KmFrom && shop.Cars[i].Km <= KmTo)
            {
                SearchResult.Add(shop.Cars[i]);
            }
        }

        foreach (var car in SearchResult)
        {
            Console.WriteLine($"Brand: {car.Brand} \r\n YearModel: {car.YearModel} \r\n Registration number: {car.RegNr} \r\n km: {car.Km}");
        }
    }

    void PurchaseCar()
    {

        Console.WriteLine("enter regstration number of the car you would like to purchase");

        var answer = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < shop.Cars.Count; i++)
        {
            if (answer == shop.Cars[i].RegNr)
            {
                Console.WriteLine($"you have purchased the car with the registration number {answer}");
                shop.Cars.Remove(shop.Cars[i]);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Registration number not found");


        }
    }

}

