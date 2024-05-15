
/*
Lag et program hvor brukeren skal gjette et tilfeldig tall mellom 1-100
Hver gang brukeren skriver inn et tall vil man få svar fra programmet om man må høyere eller lavere, helt til man gjetter riktig tall. Da skal man få spørsmål om man vil spille på nytt

public = stor
private = liten/liten med _
func navn store bokstaver

*/
mainMenu();
void mainMenu()
{
    bool runProgr = true;
    while (runProgr) {
        printRandomNr();
        Console.WriteLine("vil du spille igjen? klikk 1 for ja, 2 for nei");
        var svar = Console.ReadLine();
        if (svar == "2")
        {
            runProgr = false;
        }
    }
}
int getRandomNr() {

    Random randNr = new Random();
    var nummer = randNr.Next(0, 101);
    return nummer;
        }

void printRandomNr()
{
    var randomNr = getRandomNr();

    Console.WriteLine("gjett et tall fra 1-100");

    int answer = 0;

    while (answer != randomNr)
    {
        answer = int.Parse(Console.ReadLine());
        if (answer >= randomNr)
        {
            Console.WriteLine("too high");

        }
        else if (answer == randomNr)
        {
            Console.WriteLine("correct");
            
        }
        else
        {
            Console.WriteLine("too low");
        }
    }
}