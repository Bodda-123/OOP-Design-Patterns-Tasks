# OOP Design Patterns Tasks

Four independent C# console applications demonstrating Singleton, Observer and Factory patterns.

Requires the .NET 10 SDK.

| Task | Pattern | Source |
| --- | --- | --- |
| Singleton Logger | Singleton | [Program.cs](Task1-SingletonLogger/Program.cs) |
| TeachingAssistant Observer | Observer | [Program.cs](Task2-TeachingAssistantObserver/Program.cs) |
| ChangeExamDate | Observer | [Program.cs](Task3-ChangeExamDate/Program.cs) |
| Factory Task 1: Train | Factory | [Program.cs](Task1-FactoryPattern/Program.cs) |

Run each task from the repository folder:

```sh
dotnet run --project Task1-SingletonLogger
dotnet run --project Task2-TeachingAssistantObserver
dotnet run --project Task3-ChangeExamDate
dotnet run --project Task1-FactoryPattern
```

Task 1 prints two timestamped messages and `True`, showing that Student and Teacher use the same logger.

Task 2 prints `Ahmed: Lecture canceled`.

Task 3 prints `Sara: OOP exam moved to 20 October` and `Sara: Database exam moved to 25 October`.

Factory Task 1 adds Train at 180 LE using case 4. See the [task answer and pricing note](Task1-FactoryPattern/README.md).
