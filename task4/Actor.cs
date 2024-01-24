namespace task4;

public class Actor
{
    private string fullName;
    private int age;
    private string gender;
    List<string> moviesPlayed = new List<string>(){};
    public Actor(){} 
    public Actor(string fullName, int age, string gender)
    {
        this.fullName = fullName;
        this.age = age;
        this.gender = gender;
    }
    public void AddMovie(string moviesTitle)
    {
        moviesPlayed.Add(moviesTitle);
    } 
    public void GetMoviesPlayed()
    {
        for (int i = 0; i < moviesPlayed.Count; i++)
        {
            System.Console.WriteLine(moviesPlayed[i]);
        }
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
    
    public void SetGender(string gender)
    {
        this.gender = gender;
    }
    public int GetAge()
    {
        return age;
    }
    public string GetGender()
    {
        return gender;
    }
    public void SetName(string name)
    {
        fullName = name;
    }
    public string GetName()
    {
        return fullName;
    }
}
