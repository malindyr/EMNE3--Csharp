/*Virtual Pet
Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre egenskaper utenfra klassen. Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
Her er et eksempel på hvordan det kan se ut:

Hvilket dyr vil du ta vare på? 
Pikachu
1. Gi Pikachu mat
2. Kos med Pikachu
3. Sjekk om Pikachu må på do
2
Pikachu smiler!
1. Gi Pikachu mat
2. Kos med Pikachu
3. Sjekk om Pikachu må på do
1
Pikachu er mett og fornøyd*/

Main();
void Main()
{

    
    var Pikachu = new Pokemon("Pikachu");
    var Espeon = new Pokemon("Espeon");
    var Vaporeon = new Pokemon("Vaporeon");

    Pokemon chosenPokemon = Pikachu;
    bool isChosen = false;

    while (!isChosen)
    {

        Console.WriteLine("choose a pet to care for by pressing its corresponding number \r\n 1. Pikachu \r\n  2. Espeon \r\n 3. Vaporeon");
        var petChosen = Console.ReadLine();

        if (petChosen == "1")
        {
            chosenPokemon = Pikachu;
            isChosen = true;
            break;
        }
        else if (petChosen == "2")
        {
            chosenPokemon = Espeon;
            isChosen = true;
            break;
        }
        else if (petChosen == "3")
        {
            chosenPokemon = Vaporeon;
            isChosen = true;
            break;
        }
        else
        {
            Console.WriteLine("please enter valid answer");
        }
    }

    Console.WriteLine($"you chose {chosenPokemon.Name}! \r\n");
    chosenPokemon.stats();

      
}