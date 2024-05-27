class Engine
{
    public bool IsFaulty { get; private set; }

    public Engine(bool isFaulty)
    {
        IsFaulty = isFaulty;
    }

    public void EngineChange()
    {
        IsFaulty = false;
        Console.WriteLine("Engine fixed.");
    }
}
