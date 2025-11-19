using SchoolData.Teachers;

namespace SchoolData;

public class Teacher
{
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public List<Discipline> Disciplines = new();
}

public class TeachersData
{
    public List<Teacher> Teachers = new();
    public TeachersData()
    {
        Teachers.AddRange(
            new Abner()
        );
    }
}