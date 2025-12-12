namespace SchoolData;

public class Module
{
    public string Id { get; set; } = string.Empty;
    public string? Name;
    public bool Active { get; set; } = false;
    public string? Duration;
    public string Body { get; set; } = string.Empty;
    public List<Chapter> Chapters = new();
}

public class Chapter
{
    public string Id { get; set; } = string.Empty;
    public string? Name { get; set; } = string.Empty;
    public List<Topic> Topics { get; set; } = new();
}

public class Topic
{
    public string Id { get; set; } = string.Empty;
    public string? Name { get; set; } = string.Empty;
    public bool Active { get; set; } = false;
    public string Body { get; set; } = string.Empty;
    public List<Problems> Problems { get; set; } = new();
}

public class Problems
{
    //Estilo Flashcard
    public string Id { get; set; } = string.Empty;
    public string? Statement { get; set; } = string.Empty;
    public string? Solution { get; set; } = string.Empty;
}