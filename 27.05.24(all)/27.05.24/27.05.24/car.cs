using System.Buffers;

class Car
{
    public string Owner { get; private set; }
    public Breaks Breaks { get; private set; }

    public Engine Engine { get; private set; }

    public Car (string owner, Breaks breaks, Engine engine){

        Owner = owner;
        Breaks = breaks;
        Engine = engine;
    }
}
    


