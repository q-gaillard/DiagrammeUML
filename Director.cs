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

    public string GetFistName()
    {
        return firstName;
    }
    public string GetLastName()
    {
        return lastName;
    }
    public string GetCountry()
    {
        return country;
    }
    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }
    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }
    public void SetCountry(string country)
    {
        this.country = country;
    }

    public void Display()
    {
        Console.WriteLine($"Nom du réalisateur : {firstName} {lastName}, Pays: {country}");
    }
}