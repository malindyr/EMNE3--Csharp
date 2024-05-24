class Pokemon {

    public string Name { get; private set; }
    public int food { get; private set; }
    public int cuddles { get; private set; }
    public int bathroom { get; private set; }

    public Pokemon(string name)
    {
        Random rand = new Random();


        Name = name;
        food = rand.Next(1, 11);
        cuddles = rand.Next(1, 11);
        bathroom = rand.Next(1, 11);
    }

    public void stats()

    {

        bool isPlaying = true;

        while (isPlaying)
        {
            Console.WriteLine($"Pokemon name: {Name}\r\n Hunger level: {food} \r\n Happiness: {cuddles}\r\n Bathroom: {bathroom} \r\n");
            Console.WriteLine($"What would you like to do? \r\n 1. feed your {Name}. \r\n 2. cuddle your {Name}. \r\n 3. go to the bathroom with your {Name}\r\n 4. exit game");
            var answer = Console.ReadLine();

            if (answer == "1")
            {
                feed();
            } else if(answer == "2")
            {
                cuddle();
            }
            else if (answer == "3")
            {
                wc();
            }
            else if (answer == "4")
            {
                Environment.Exit(0);
            }
        }
    }

    public void feed()
    {
        food ++;
        cuddles--;
        Console.WriteLine($"you fed your {Name}! Hunger level: {food}");
    }

    public void cuddle()
    {
        cuddles++;
        bathroom--;
        Console.WriteLine($"you cuddled your {Name}! Happiness level {cuddles}");
    }

    public void wc()
    {
        bathroom++;
        food--;
        Console.WriteLine($"you went to the bathroom with your {Name}. Bathroom stats {bathroom}");
    }
}