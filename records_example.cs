using System;

record Student(string Name, double Score, char Grade);

class Program
{
    static void Main()
    {
        var students = new[]
        {
            new Student("Sophia", 94.6, 'A'),
            new Student("Nicolas", 83.6, 'B'),
            new Student("Zahirah", 83.4, 'B'),
            new Student("Jeong", 95.4, 'A')
        };

        // Table header
        Console.WriteLine(new string('-', 25));
        Console.WriteLine($"{"Student",-10} {"Score",-6} Grade");
        Console.WriteLine(new string('-', 25));

        // Table rows
        foreach (var s in students)
        {
            Console.WriteLine($"{s.Name,-10} {s.Score,-6:F1} {s.Grade}");
        }
    }
}
