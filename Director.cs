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