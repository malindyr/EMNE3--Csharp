class Program
{
    int points = 0;
    public void generateNumbers()
    {
        Random rand = new Random();
        int randomNr1 = rand.Next(0, 6);
        int randomNr2 = rand.Next(0, 6);

        displayNumbers(randomNr1, randomNr2);
    }
    public void displayNumbers(int nr1, int nr2)
    {
        Console.WriteLine($"{nr1}_{nr2}");
        var input = Console.ReadLine();

        if (nr1 < nr2 && input == "<")
        {   points++;
            Console.WriteLine("correct!");
            Console.WriteLine($"points: {points}");
            generateNumbers();
        }
        else if (nr2 < nr1 && input == ">")
        {   points++;
            Console.WriteLine("correct!");
            Console.WriteLine($"points: {points}");
            generateNumbers();
        }
        else if (nr1 == nr2 && input == "=")
        {   points++;
            Console.WriteLine("corrct!");
            Console.WriteLine($"points: {points}");
            generateNumbers();
        }
        else if (input !="<" && input !=">" && input !="=")
        {   Console.WriteLine("game over:(");
        }
        else
        {   points = points - 1;
            Console.WriteLine("wrong");
            Console.WriteLine($"points: {points}");
            generateNumbers();
        }}
    static void Main()
    {
        Program run = new Program();
        run.generateNumbers();
    }
}