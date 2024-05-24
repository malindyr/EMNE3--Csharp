/*Oppgave: Organ transplant!
Det har vært en akutt ulykke og Bernt ligger på sykehuset.

Han trenger en ny Nyre! sunne nyrer - 0/2

Heldigvis har fetteren hans Kåre to sunne Nyrer, 
og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse! - 1 nyre stor sjans for overlevelse

Hjelp Bernt med å overleve!

Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet. - bernt objekt kåre objekt, nyrer 

Lag gjerne Consoll.WriteLine() - statements i koden slik at man ser hva som skjer!

*/

var Bernt = new People("Bernt", 0, true);
var Kåre = new People("Kåre", 2, true);
bool giveKidney = false;

mainMenu();
void mainMenu()
{
    Console.WriteLine($"Det har vært en akutt ulykke og Bernt ligger på sykehuset.Han trenger en ny Nyre! {Environment.NewLine}");
    Console.WriteLine($"Heldigvis har fetteren hans Kåre to sunne Nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse!{Environment.NewLine}");
    Console.WriteLine($"Pasientens navn: {Bernt.Name}. \nAntall friske nyrer: {Bernt.HealthyKidneys}. \nI live? {Bernt.IsAlive}  {Environment.NewLine}");
    Console.WriteLine($"Donor navn: {Kåre.Name}., \nAntall fliske nyrer {Kåre.HealthyKidneys}. \nI live? {Kåre.IsAlive}{Environment.NewLine}");
    Console.WriteLine("Press 1 for å donere en av Kåre sine nyrer til Bernt.");
    hurry();
}
void hurry()
{
    int tries = 0;
    while (!giveKidney && tries<3)
    {
        var answer = Console.ReadLine();

        if (answer == "1")
        {
            giveKidney = true;
        }
        else
        {
            if (tries < 2) { Console.WriteLine("kom igjen Kåre, det er ennå tid! Gi Bernt en sjanse på livet!"); };
            tries++;
        }
    };

    result();
}

void result()
{

    Bernt.IsAlive = giveKidney && new Random().Next(0, 10) != 1;
    Bernt.HealthyKidneys += Bernt.IsAlive ? 1 : 0;

    Console.WriteLine($"Pasientens navn: {Bernt.Name}. \nAntall friske nyrer: {Bernt.HealthyKidneys}. \nI live? {Bernt.IsAlive}  {Environment.NewLine}");
}
