class Movie
{
    private string title;
    private int duration;
    private Director director;
    private Studio studio;

    public Movie(string title, int duration, Director director, Studio studio)
    {
        this.title = title;
        this.duration = duration;
        this.director = director;
        this.studio = studio;
    }

    public Movie()
    {
        this.title = "Untitled";
        this.duration = 0;
        this.director = new Director();
        this.studio = new Studio();
    }

    public string GetTitle()
    {
        return title;
    }
    public int GetDuration()
    {
        return duration;
    }
    public Director GetDirector()
    {
        return director;
    }
    public Studio GetStudio()
    {
        return studio;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
    public void SetDuration(int duration)
    {
        this.duration = duration;
    }
    public void SetDirector(Director director)
    {
        this.director = director;
    }
    public void SetStudio(Studio studio)
    {
        this.studio = studio;
    }

    public void Display()
    {
        Console.WriteLine($"Titre du film : {title}, Réalisateur: {director.FirstName} {director.LastName}, Durée: {duration} minutes, Studio: {studio.Name}");
    }
}