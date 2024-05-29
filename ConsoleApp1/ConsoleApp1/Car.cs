class Car
{
    public string Brand { get; private set; }
    public int YearModel { get; private set; }
    public string RegNr { get; private set; }
    public int Km { get; private set; }

    public Car(string brand, int yearmodel, string regNr, int km)
    {
        Brand = brand;
        YearModel = yearmodel;
        RegNr = regNr;
        Km = km;
    }

}