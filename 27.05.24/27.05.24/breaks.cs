class Breaks
{
    public bool IsFaulty { get; private set; }

    public Breaks(bool isFaulty)
    {
        IsFaulty = isFaulty;
    }

    public void BreakChange()
    {
        IsFaulty = false;
        Console.WriteLine("Breaks fixed.");
    }

}