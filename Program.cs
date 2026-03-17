using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiagrammeUML;

class Program
{
    static void Main(string[] args)
    {
        // Création d'une instance de Director
        Director director1 = new Director("Christopher", "Nolan", "UK");
        director1.Display();

        Director director2 = new Director("Peter", "Weir", "Australia");
        director2.Display();

        Director director3 = new Director("Chris", "Columbus", "USA");
        director3.Display();

        // Création d'une instance de Movie
        Movie movie1 = new Movie("Inception", 148, director1);
        movie1.Display();

        Movie movie2 = new Movie("the truman show", 103, director2);
        movie2.Display();

        Movie movie3 = new Movie("Harry Potter", 120, director3);
        movie3.Display();

        // Création d'une instance de Playlist
        Playlist playlist1 = new Playlist("Mes films préférés");
        playlist1.AddMovie(movie1);
        playlist1.AddMovie(movie2);
        playlist1.Display();
        // Ajout d'un troisième film à la playlist
        playlist1.AddMovie(movie3);
        playlist1.Display();
    }
}