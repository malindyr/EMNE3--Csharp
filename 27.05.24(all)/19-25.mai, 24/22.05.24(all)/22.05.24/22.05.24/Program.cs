/*Lag applikasjon FriendFace. Det er tiltenkt at dette skal bli det nyeste kule sosiale mediet som tar verden med storm. Her trenger en bruker en profilside med diverse info om seg (ta gjerne inspirasjon fra andre sosiale medier),

Du må lage en metode som heter “AddFriend” og en metode “RemoveFriend”.

Når programmet starter opp skal du lage en hovedbruker som er “innlogget”. Du må også opprette flere forskjellige brukere som lever på det sosiale mediet.

Lag et kommandbasert meny i konsollen der du kan:

Legge til forskjellige brukere som venn (på den som er innlogget)
Fjerne brukere som venn
Printe ut en liste av alle man har lagt til som venn
Velge en av vennene og printe ut profilinformasjonen deres.*/

using System.Security.Cryptography.X509Certificates;

Main();
void Main()
{

    
    List<User> Allusers = new List<User> {
    new User("bjørnar", 1),
    new User("vegar", 2),
    new User("trine", 3),
    new User("anne", 4),
    new User("vidar", 5),
    };

    var Malin = new LoggedInUser("malin", Allusers);
    Console.WriteLine($"currently logged in: {Malin.returnUsername()} \r\n");

    var textline = "";
    foreach(User user in Allusers)
    {
        textline += user.Username + ", userId: " + user.UserID + "\r\n";
    }
    Console.WriteLine($"all users: \r\n {textline}");

    whatToDo(Malin);

}

void whatToDo(LoggedInUser Malin)
{
    bool menubar = true;
    while (menubar)
    {
        Console.WriteLine("what would you like to do? \r\n write in corresponding task number: \r\n 1. Add a friend to your friendList. \r\n 2. Remove a friend from your friendList. \r\n 3.View a friends info \r\n 4. View friendList \r\n 5. Exit program");
        int answer = int.Parse(Console.ReadLine());

        if (answer == 1)
        {
            Malin.AddFriend();
        }
        else if (answer == 2)
        {
            Malin.RemoveFriend();
        }
        else if (answer == 3)
        {
            Malin.ViewFriendInfo();
        }
        else if (answer == 4)
        {
            Malin.PrintFriends();
        }
        else if (answer == 5)
        {
            menubar = false;
        }
        else { Console.WriteLine("please choose an option/write a valid answer"); }
    }
}


