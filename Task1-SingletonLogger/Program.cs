using System;
using System.Collections.Generic;

class Logger
{
    private static readonly Logger instance = new Logger();
    private readonly List<string> messages = new List<string>();
    private readonly object locker = new object();

    private Logger() { }

    public static Logger Instance => instance;

    public void Log(string message)
    {
        lock (locker)
        {
            messages.Add($"{DateTime.Now}: {message}");
        }
    }

    public void PrintAll()
    {
        lock (locker)
        {
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}

class Student
{
    public Logger logger = Logger.Instance;

    public void Run()
    {
        logger.Log("Message from Student");
    }
}

class Teacher
{
    public Logger logger = Logger.Instance;

    public void Run()
    {
        logger.Log("Message from Teacher");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        Teacher t = new Teacher();

        s.Run();
        t.Run();

        s.logger.PrintAll();

        Console.WriteLine(ReferenceEquals(s.logger, t.logger));
    }
}
