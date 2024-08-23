class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }

    public string Description { get; set; }
    public string Actors { get; set; }

    public Movie(string title, string director, string description, string actors)
    {
        Title = title;
        Director = director;
        Description = description;
        Actors = actors;
    }

    public void showDescription()
    {
        Console.WriteLine($"movie title {Title} \r\n director: {Director} \r\n description{Description} \r\n actors: {Actors}");    

    }
}