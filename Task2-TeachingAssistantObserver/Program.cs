using System;

class Course
{
    public event Action<string> Notify;

    public void SendNotification(string message)
    {
        Notify?.Invoke(message);
    }
}

class TeachingAssistant
{
    public string Name;

    public TeachingAssistant(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine(Name + ": " + message);
    }
}

class Program
{
    static void Main()
    {
        Course course = new Course();
        TeachingAssistant ta = new TeachingAssistant("Ahmed");

        course.Notify += ta.Update;

        course.SendNotification("Lecture canceled");
    }
}
