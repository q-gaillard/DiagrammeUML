class Media
{
    protected string title;
    protected int duration;

    public Media(string title, int duration)
    {
        this.title = title;
        this.duration = duration;
    }

    public Media()
    {
        this.title = "Untitled";
        this.duration = 0;
    }

    public string GetTitle()
    {
        return title;
    }
    public int GetDuration()
    {
        return duration;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
    public void SetDuration(int duration)
    {
        this.duration = duration;
    }

}