using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiagrammeUML;

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

class Director
{
    private string firstName;
    private string lastName;
    private string country;

    public Director(string firstName, string lastName, string country)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.country = country;
    }

    public Director()
    {
        this.firstName = "not defined";
        this.lastName = "not defined";
        this.country = "not defined";
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public void Display()
    {
        Console.WriteLine($"Nom du réalisateur : {firstName} {lastName}, Pays: {country}");
    }
}
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