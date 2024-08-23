
class LoggedInUser(string username, List<User> allusers)
{
    private string Username { get; set; } = username;
    public List<User> Allusers = allusers;
    public List<User> Friends { get; set; } = new List<User>();

    public string returnUsername()
    {
        return Username;
    }
    public void AddFriend()
    {
        Console.WriteLine("write the user ID of the person you would like to add to your friendList");
        var inputId = int.Parse(Console.ReadLine());

        bool foundUser = false;
        int i = 0;
        while (!foundUser && i < Allusers.Count)
        {
            if (Allusers[i].UserID == inputId)
            {
                Console.WriteLine($"user ID found! {Allusers[i].Username} was added to your friendList.\r\n");
                Friends.Add(Allusers[i]);
                foundUser = true;
            }
            else { i++; }
        }
        if (!foundUser)
        {
            Console.WriteLine("user not found/userId input invalid");
        }
    }

    public void RemoveFriend()
    {

        Console.WriteLine("write the userID of the person you want to remove from your friendList");
        var inputId = int.Parse(Console.ReadLine());

        bool foundUser = false;
        int i = 0;
        while (!foundUser && i < Friends.Count)
        {
            if (Friends[i].UserID == inputId)
            {
                Console.WriteLine($"user ID found! {Friends[i].Username} was removed from your friendList.\r\n");
                Friends.Remove(Friends[i]);
                foundUser = true;
            }
            else { i++; };
        }
        if (!foundUser)
        {
            Console.WriteLine("user not found/userId input invalid");
        }
    }

    public void ViewFriendInfo()
    {

        Console.WriteLine("write the userID of the person you want to view");
        var inputId = int.Parse(Console.ReadLine());

        bool foundUser = false;
        int i = 0;
        while (!foundUser && i < Friends.Count)
        {
            if (Friends[i].UserID == inputId)
            {
                Console.WriteLine($"user ID found! \r\n {Friends[i].Username} info: \r\n is in your friendList");
            }
            else { i++; }

        }
        if (!foundUser) { Console.WriteLine("user not found/userId input invalid"); };
    }

    public void PrintFriends()
    {
        foreach (User user in Friends) { Console.WriteLine($"\r\n friend list: \r\n{user.Username}, id: {user.UserID}\r\n"); };
    }
}