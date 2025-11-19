using SchoolData.Disciplines;

namespace SchoolData;

public class Discipline
{
    public int Id { get; set; }
    public string Name = string.Empty;
    public string Label = string.Empty;
    public string Subtitle = string.Empty;
    public string Description = string.Empty;
    public decimal Price = 0;
    public bool Active = false;
    public Dictionary<string, object>? Sections = new();
    public List<Course> Courses = new();
    public virtual List<Course> GenerateCourses() { return new(); }

    public Dictionary<string, object> GenerateSections()
    {
        return new()
        {
            {Name, Subtitle},
            {"Sobre", Description},
        };
    }
}

public class DisciplinesData
{
    public List<Discipline> Disciplines = new();
    public DisciplinesData()
    {
        Disciplines.AddRange(
            new DisciplineMath(),
            new DisciplinePhysics(),
            new DisciplinePortuguese()
        );
    }
}

