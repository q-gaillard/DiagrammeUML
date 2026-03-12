using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiagrammeUML;

class Program
{
    static void Main(string[] args)
    {
        // Création d'une instance de Movie
        Movie movie1 = new Movie("Inception", 148);
        movie1.Display();

        // Création d'une instance de Director
        Director director1 = new Director("Christopher", "Nolan", "UK");
        director1.Display();
    }
}