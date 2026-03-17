using System.Reflection;
using System.Runtime.CompilerServices;

class Playlist
{
    private string name;
    private List<Movie> movies;

    public Playlist(string name)
    {
        this.name = name;
        this.movies = new List<Movie>();
    }

    public Playlist()
    {
        this.name = "untitled";
        this.movies = new List<Movie>();
    }

    public void Display()
    {
        Console.WriteLine($"Playlist: {name}");
        Console.WriteLine("liste des films:");
        foreach (Movie movie in movies)
        {
            Console.WriteLine($"- {movie.Title} ({movie.Duration} minutes) réalisé par {movie.Director.FirstName} {movie.Director.LastName}");
        }
    }

    public void AddMovie(Movie movie)
    {
        movies.Add(movie);
    }
}