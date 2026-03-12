class Movie
{
    private string title;
    private int duration;

    public Movie(string title, int duration)
    {
        this.title = title;
        this.duration = duration;
    }

    public Movie()
    {
        this.title = "Untitled";
        this.duration = 0;
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

    public void Display()
    {
        Console.WriteLine($"Titre du film : {title}, Durée: {duration} minutes");
    }
}