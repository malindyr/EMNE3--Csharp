/*Test ut overloads og default verdier selv ved å lage en metode PrintWelcomeMessage() som printer ut "Hei og velkommen".

Lag en overload metode som kan ta inn et navn og legge det til i velkomstmeldingen, dette navnet skal default være "Terje" 
med mindre noe annet er oppgitt.*/


using _13._05._24__3_;

PrintWelcomeMessage();
void PrintWelcomeMessage(string navn = "Terje")
{
    var malin = new Person("Malin");

    navn = malin.Name;

    Console.WriteLine($"hei, {navn}");
    

}