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

    public string GetName()
    {
        return name;
    }
    public string GetCity()
    {
        return city;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetCity(string city)
    {
        this.city = city;
    }

    public void Display()
    {
        Console.WriteLine($"Studio: {name}, Ville: {city}");
    }
}