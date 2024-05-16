
public class Dog
{
    public string breed { get; set; } //get; set; - property,  oop
    public string name { get; set; }

    private string lore { get; set; } //can only be accessed from within the class, cant be accessed from outside of the class here

    public void AssignValues(string breedArg, string nameArg) //AssignValues is a method
    {
        breed = breedArg; //sets breed to breed argument       " goldenRetriever.name = "tinka";"
        name = nameArg;   //sets name to name argument         "welsh.breed = "welsh springer spaniel"
    }

    public void AssignLore(string loreArg)
    {
        lore = loreArg;   //sets lore value to lore argument(parameter)value. has to be done through method within class because lore is private
    }

    public string ShowLore() //can only show lore through method, because lore can only be accessed through dog class, because lore is private
    {
        return lore;
    }

    public void barkMethod() //method for barking
    {
        Console.WriteLine("bark!");
    }
}


