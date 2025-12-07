namespace SchoolData;

public class Course
{
    public string Id { get; set; } = string.Empty;
    public string? Name;
    public List<Content> Curriculum = new();
}