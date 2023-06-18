namespace solid_principles_example_project;

public abstract class CourseCorrect
{
    public int CourseId { get; set; }
    public string? Title { get; set; }

    public abstract void Subscribe(Student std);
}

public class OfflineCourse : CourseCorrect
{
    public override void Subscribe(Student std)
    {
        // Subscribe to offline course
    }
}

public class OnlineCourse : CourseCorrect
{
    public override void Subscribe(Student std)
    {
        // Subscribe to online course
    }
}