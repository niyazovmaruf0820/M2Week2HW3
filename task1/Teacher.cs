namespace task1;

public class Teacher
{
    public Teacher(){}
    public Teacher(string name, string subject)
    {
        FullName = name;
        Subject = subject;
    }
    public Teacher(string name, string subject, int experience)
    {
        FullName = name;
        Subject = subject;
        Experience = experience;
    }
    private string FullName;
    private string Subject;
    private int Experience;
    public string Teach()
    {
        return $"{FullName} is teaching {Subject}";
    }
    public void SetExperience(int years)
    {
        Experience = years;
    } 
    public int GetExperience()
    {
        return Experience;
    }
}
