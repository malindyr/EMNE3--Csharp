using System.Reflection;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public string Characters { get; set; }


    public Book(string title, string author, string desctiption, string characters)
    {
        Title = title;
        Author = author;
        Description = desctiption;
        Characters = characters;
    }

    
}
