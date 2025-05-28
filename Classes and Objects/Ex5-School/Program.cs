using System;
using System.Collections.Generic;

// Step 1: Define the Person class
public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}

// Step 2: Define the Student and Teacher classes
public class Student : Person
{
    public Student(string name) : base(name) { }
}

public class Teacher : Person
{
    public Teacher(string name) : base(name) { }
}

// Step 3: Define the Classroom class
public class Classroom
{
    public string ClassName { get; set; }
    public Teacher ClassTeacher { get; set; }
    public List<Student> Students { get; set; }

    public Classroom(string className, Teacher classTeacher)
    {
        ClassName = className;
        ClassTeacher = classTeacher;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
        Console.WriteLine($"Added student {student.Name} to class {ClassName}");
    }

    public void RemoveStudent(string studentName)
    {
        Student studentToRemove = Students.Find(s => s.Name == studentName);
        if (studentToRemove != null)
        {
            Students.Remove(studentToRemove);
            Console.WriteLine($"Removed student {studentName} from class {ClassName}");
        }
        else
        {
            Console.WriteLine($"Student {studentName} not found in class {ClassName}");
        }
    }
}

// Step 4: Define the School class
public class School
{
    private List<Student> students = new List<Student>();
    private List<Teacher> teachers = new List<Teacher>();
    private List<Classroom> classrooms = new List<Classroom>();

    // Method to add a student
    public void AddStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"Added student {student.Name}");
    }

    // Method to remove a student
    public void RemoveStudent(string studentName)
    {
        Student studentToRemove = students.Find(s => s.Name == studentName);
        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            Console.WriteLine($"Removed student {studentName}");
        }
        else
        {
            Console.WriteLine($"Student {studentName} not found.");
        }
    }

    // Method to add a teacher
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
        Console.WriteLine($"Added teacher {teacher.Name}");
    }

    // Method to remove a teacher
    public void RemoveTeacher(string teacherName)
    {
        Teacher teacherToRemove = teachers.Find(t => t.Name == teacherName);
        if (teacherToRemove != null)
        {
            teachers.Remove(teacherToRemove);
            Console.WriteLine($"Removed teacher {teacherName}");
        }
        else
        {
            Console.WriteLine($"Teacher {teacherName} not found.");
        }
    }

    // Method to create a class
    public void CreateClass(string className, string teacherName)
    {
        Teacher classTeacher = teachers.Find(t => t.Name == teacherName);
        if (classTeacher != null)
        {
            Classroom classroom = new Classroom(className, classTeacher);
            classrooms.Add(classroom);
            Console.WriteLine($"Created class {className} with teacher {classTeacher.Name}");
        }
        else
        {
            Console.WriteLine($"Teacher {teacherName} not found.");
        }
    }

    // Public property to access classrooms
    public List<Classroom> Classrooms
    {
        get { return classrooms; }
    }
}

// Main method to test the School class
class Program
{
    static void Main()
    {
        School school = new School();

        Student student1 = new Student("Alice");
        Student student2 = new Student("Bob");
        Teacher teacher1 = new Teacher("Mr. Smith");

        school.AddStudent(student1);
        school.AddStudent(student2);
        school.AddTeacher(teacher1);

        school.CreateClass("Math", "Mr. Smith");

        Classroom mathClass = school.Classrooms[0];
        mathClass.AddStudent(student1);
        mathClass.AddStudent(student2);

        mathClass.RemoveStudent("Bob");
    }
}
