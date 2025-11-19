using SchoolData.Disciplines;

namespace SchoolData.Teachers;

public class Abner : Teacher
{
    public Abner()
    {
        Name = "Abner Cruz";
        ImageUrl = "images/teachers/AbnerCruz.png";
        Disciplines = new()
        {
            new DisciplineMath(),
            new DisciplinePhysics(),
        };
    }
}