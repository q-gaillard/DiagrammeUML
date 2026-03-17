using System.Net.Http.Headers;

class Serie : Media
{
    private int seasonsCount;

    public Serie(string title, int duration, int seasonsCount)
    {
        this.title = title;
        this.duration = duration;
        this.seasonsCount = seasons;
    }

    public Serie()
    {
        this.title = "Untitled";
        this.duration = 0;
        this.seasonsCount = 0;
    }

    public int GetSeasonsCount()
    {
        return seasonsCount ;
    }
    public void SetSeasonsCount(int seasonsCount)
    {
        this.seasonsCount = seasonsCount;
    }

    public void Display()
    {
        Console.WriteLine($"Titre de la série : {title}, Durée: {duration} minutes, Nombre de saisons: {seasonsCount}");
    }
}