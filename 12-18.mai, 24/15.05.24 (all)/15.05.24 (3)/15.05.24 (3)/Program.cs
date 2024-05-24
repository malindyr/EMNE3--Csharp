

var goldenRetriever = new Dog();
{
    goldenRetriever.breed = "golden retriever"; //public string
    goldenRetriever.name = "tinka";             //public string
}

goldenRetriever.AssignLore("childhood dog");    //lore is private string

Console.WriteLine(goldenRetriever.name);        //accessing public property
Console.WriteLine(goldenRetriever.breed);       //accessing public property

Console.WriteLine(goldenRetriever.ShowLore()); //Accessing private field via method

// Console.WriteLine(goldenRetriever.lore)   inaccessible due to protection level

goldenRetriever.barkMethod();



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


var welsh = new Dog();
welsh.AssignValues("welsh springer spaniel", "Freia"); //setting properties via assignvalues method
welsh.AssignLore("loves running after cats but is terrified of kittens"); //Accessing private field via method

Console.WriteLine(welsh.name);        //accessing public property
Console.WriteLine(welsh.breed);       //accessing public property

Console.WriteLine(welsh.ShowLore()); //Accessing private field via method
welsh.barkMethod();

