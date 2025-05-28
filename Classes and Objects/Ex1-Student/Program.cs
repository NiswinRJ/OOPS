using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public string Grade { get; set; }
    public List<string> Courses { get; set; }

    public Student(string name, string grade)
    {
        Name = name;
        Grade = grade;
        Courses = new List<string>();
    }

    public void AddCourse(string course)
    {
        Courses.Add(course);
        Console.WriteLine($"{course} has been added to {Name}'s courses.");
    }

    public void RemoveCourse(string course)
    {
        if (Courses.Remove(course))
        {
            Console.WriteLine($"{course} has been removed from {Name}'s courses.");
        }
        else
        {
            Console.WriteLine($"{course} is not found in {Name}'s courses.");
        }
    }

    public void DisplayCourses()
    {
        Console.WriteLine($"{Name}'s Courses:");
        foreach (string course in Courses)
        {
            Console.WriteLine($"- {course}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter student's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter student's grade: ");
        string grade = Console.ReadLine();

        Student student = new Student(name, grade);
        
        Console.WriteLine("Enter courses to add (type 'done' to finish):");
        string course;
        while ((course = Console.ReadLine()) != "done")
        {
            student.AddCourse(course);
        }

        student.DisplayCourses();
        
        Console.WriteLine("Enter courses to remove (type 'done' to finish):");
        while ((course = Console.ReadLine()) != "done")
        {
            student.RemoveCourse(course);
        }
        student.DisplayCourses();
    }
}
