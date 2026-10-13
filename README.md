# OOP Design Patterns Tasks

Three independent C# console applications demonstrating Singleton and Observer patterns.

Requires the .NET 10 SDK.

| Task | Pattern | Source |
| --- | --- | --- |
| Singleton Logger | Singleton | [Program.cs](Task1-SingletonLogger/Program.cs) |
| TeachingAssistant Observer | Observer | [Program.cs](Task2-TeachingAssistantObserver/Program.cs) |
| ChangeExamDate | Observer | [Program.cs](Task3-ChangeExamDate/Program.cs) |

Run each task from the repository folder:

```sh
dotnet run --project Task1-SingletonLogger
dotnet run --project Task2-TeachingAssistantObserver
dotnet run --project Task3-ChangeExamDate
```

Task 1 prints two timestamped messages and `True`, showing that Student and Teacher use the same logger.

Task 2 prints `Ahmed: Lecture canceled`.

Task 3 prints `Sara: OOP exam moved to 20 October` and `Sara: Database exam moved to 25 October`.
