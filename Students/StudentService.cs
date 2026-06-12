using System;
using System.Collections.Generic;

class StudentService
{
    private Dictionary<string, Dictionary<string, int>> studentData = new();

    public void AddStudent()
    {
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        var subjects = new Dictionary<string, int>();

        subjects["Math"] = GetScore("Math");
        subjects["Psychology"] = GetScore("Psychology");
        subjects["Programming"] = GetScore("Programming");

        int avg = (subjects["Math"] + subjects["Psychology"] + subjects["Programming"]) / 3;
        subjects["Average"] = avg;

        studentData[studentName] = subjects;

        Console.WriteLine($"Student {studentName} added successfully!");
    }

    private int GetScore(string subject)
    {
        Console.WriteLine($"Enter score for {subject}: ");
        return int.Parse(Console.ReadLine());
    }

    public void ListStudents(bool showAverage)
    {
        foreach (var student in studentData)
        {
            Console.WriteLine($"\n--- {student.Key} ---");

            foreach (var s in student.Value)
            {
                if (s.Key == "Average" && !showAverage)
                    continue;

                Console.WriteLine($"{s.Key}: {s.Value}");
            }
        }
    }

    public void FilterByAverage(int min, int max, ConsoleColor color, string label)
    {
        Console.WriteLine($"\n{label}");

        foreach (var student in studentData)
        {
            int avg = student.Value["Average"];

            if (avg >= min && avg <= max)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{student.Key} -> Average: {avg}");
                Console.ResetColor();
            }
        }
    }
}
