namespace SchoolData;

public class Content
{
    public string Id { get; set; } = string.Empty;
    public string? Name;
    public string? Duration;
    public List<Topic> Contents = new();
}

public class Topic
{
    public string Id { get; set; } = string.Empty;
    public string? Name;
    public string Body { get; set; } = string.Empty;
}