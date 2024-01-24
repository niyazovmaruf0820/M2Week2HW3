namespace task2;

public class Student
{
    private string FullName;
    private int Age;
    private int Grade;
    public Student(){}
    public Student(string name, int age)
    {
        FullName = name;
        Age = age;
    }
    public Student(string name, int age, int grade)
    {
        FullName = name;
        Age = age;
        Grade = grade;
    }
    public string Study()
    {
        return $"{FullName} is studying.";
    }
    public void SetGrade(int grade)
    {
        Grade = grade;
    }
    public int GetGrade()
    {
        return Grade;
    }
}
