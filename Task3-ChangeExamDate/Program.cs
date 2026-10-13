using System;

class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine(Name + ": " + message);
    }
}

class Course
{
    public string Name;

    public event Action<string> Notify;

    public Course(string name)
    {
        Name = name;
    }

    public void Register(Student student)
    {
        Notify += student.Update;
    }

    public void ChangeExamDate(string date)
    {
        Notify?.Invoke(Name + " exam moved to " + date);
    }
}

class Program
{
    static void Main()
    {
        Student sara = new Student("Sara");

        Course oop = new Course("OOP");
        Course database = new Course("Database");

        oop.Register(sara);
        database.Register(sara);

        oop.ChangeExamDate("20 October");
        database.ChangeExamDate("25 October");
    }
}
