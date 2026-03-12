class Movie
{
    private string title;
    private int duration;
    private Director director;

    public Movie(string title, int duration, Director director)
    {
        this.title = title;
        this.duration = duration;
        this.director = director;
    }

    public Movie()
    {
        this.title = "Untitled";
        this.duration = 0;
        this.director = new Director();
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }
    public Director Director
    {
        get { return director; }
        set { director = value; }
    }

    public void Display()
    {
        Console.WriteLine($"Titre du film : {title}, Réalisateur: {director.FirstName} {director.LastName}, Durée: {duration} minutes");
    }
}