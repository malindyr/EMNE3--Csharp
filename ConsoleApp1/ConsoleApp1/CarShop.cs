class CarShop
{
   public List<Car> Cars { get; private set; }

    public CarShop()
    {
        Cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void ShowAllCars()
    {
        foreach (var car in Cars)
        {
            Console.WriteLine($"Brand: {car.Brand} \r\n YearModel: {car.YearModel} \r\n Registration number: {car.RegNr} \r\n km: {car.Km}");
        }
    }
}