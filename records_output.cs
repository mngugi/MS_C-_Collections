using System;

record Student(int Id, string Name, int Age);

class Program
{
    static void Main()
    {
        // Create some records
        Student s1 = new Student(1, "Alice", 12);
        Student s2 = new Student(2, "Brian", 13);
        Student s3 = new Student(3, "Carol", 11);

        // Output records
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
    }
}
