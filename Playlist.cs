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

    public string GetName()
    {
        return name;
    }
    public List<Movie> GetMovies()
    {
        return movies;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetMovies(List<Movie> movies)
    {
        this.movies = movies;
    }

    public void Display()
    {
        Console.WriteLine($"Playlist: {name}");
        Console.WriteLine("liste des films:");
        foreach (Movie movie in movies)
        {
            Console.WriteLine($"- {movie.Title}");
        }
    }

    public void AddMovie(Movie movie)
    {
        movies.Add(movie);
    }
}