class Studio
{
    private string name;
    private string city;

    public Studio(string name, string city)
    {
        this.name = name;
        this.city = city;
    }

    public Studio()
    {
        this.name = "untitled";
        this.city = "not defined";
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public void Display()
    {
        Console.WriteLine($"Studio: {name}, Ville: {city}");
    }
}