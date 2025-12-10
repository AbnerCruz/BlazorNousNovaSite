namespace SchoolData;

public class Module
{
    public string Id { get; set; } = string.Empty;
    public string? Name;
    public string? Duration;
    public string Body { get; set; } = string.Empty;
    public List<Chapter> Chapters = new();
}

public class Chapter
{
    public string Id { get; set; } = string.Empty;
    public string? Name;
    public List<Topic> Topics { get; set; } = new();
}

public class Topic
{
    public string Id { get; set; } = string.Empty;
    public string? Name;
    public string Body { get; set; } = string.Empty;
}