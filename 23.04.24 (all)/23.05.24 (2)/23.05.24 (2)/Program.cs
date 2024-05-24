/*Bok/Film-info
Lag en applikasjon der man kan skrive inn forskjellige detaljer, og etter man har skrevet inn alt få printet tilbake det som ble skrevet inn som et “produkt”, enten en film eller en bok, dere velger.
Man skal bli spurt av konsollen om Tittel, så år det kom ut, litt beskrivelse av hva filmen eller boken handler om, forfatter/regissør, hvilke skuespillere som var med.
Når alle spørsmål er besvart skal man kunne få se boken eller filmen man skrev inn som et produkt, med alle egenskaper listet opp.*/

Main();
void Main()
{

    List<Book> bookLibrary = new List<Book>();

    Console.WriteLine("Press 1 to add a book \r\n Press 2 to add a movie \r\n press 3 to view mov");
    var bookOrMovie = "";
;
    while (bookOrMovie != "1" && bookOrMovie != "2")
    {

        bookOrMovie = Console.ReadLine();

        if (bookOrMovie == "1")
        {
            addBook();
        }
        else if (bookOrMovie == "2")
        {
            addMovie();
        }
        else
        {
            Console.WriteLine("please press 1 or 2");
        }
    }

}

void addBook()
{
    string[] answers = new string[4];
    bool answered = false;

    Console.WriteLine("please provide the following information: \r\n 1.Title \r\n 2.Author \r\n 3.Description \r\n 4.Characters");

    while (!answered)
    {
        for (int i = 0; i < answers.Length; i++)
        {
            Console.WriteLine($"enter answer for point {i+1}");
            answers[i] = Console.ReadLine();
        }

        answered = true;
        for(int i=0; i<answers.Length; i++)
        {
            if (string.IsNullOrEmpty(answers[i])){

                Console.WriteLine($"point {i + 1} has not been answered");
                answered = false;
                break;
            }
        }
        if (!answered)
        {
            Console.WriteLine("provide answers for all points please");
        }
    }

    new Book(answers[0], answers[1], answers[2], answers[3]);

    Console.WriteLine($"{answers[0]} was added to your library \r\n Book title: {answers[0]} \r\n Author: {answers[1]} \r\n Description: {answers[2]} \r\n Characters: {answers[3]}");

}

void addMovie()
{
    string title = Console.ReadLine();
    string director = Console.ReadLine();
    string description = Console.ReadLine();
    string actors = Console.ReadLine();
}