using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    public static void Main(string[] args)
    {
        //Creating Employee List
        List<Employee> employees = new List<Employee>
        {
            new Employee{Name="Ram",Age=25}, //Adding name and age of employees into the list
            new Employee{Name="Hari",Age=32},
            new Employee{Name="Sita",Age=55},
            new Employee{Name="Jun",Age=29},
            new Employee{Name="Kabi",Age=45}
        };
        //Using Linq to find the employee who's age is above 30
        var employeeAbove30 = employees.Where(e => e.Age > 30).Select(e=>e.Name);
        foreach(var name in employeeAbove30)
        {
            Console.WriteLine(name);    // Print the name of employee who are above 30
        }

        //Creating the list of numbers
        List<int> numbers = new List<int> {1,22,3,5,52,43,34,21,5,6,32,6,5,3,76};
        List<int> evenNumbers = numbers.evenNumber();

        foreach(var num in evenNumbers)
        {
            Console.Write(num+" "); // Printing the even Numbers.
        }

        //Creating the list of students
        List<Student> students = new List<Student>
        {
            new Student{Name="Nil"},
            new Student{Name="Kamal"},
            new Student{Name="Bimal"},
            new Student{Name="Jane"},
            new Student{Name="Kumar"},
            new Student{Name="Rita"},
            new Student{Name="Isha"}
        };
        List<Student> sortedStudents = students.SortStudentName();

        Console.WriteLine("\nStudents sorted by name (Descending):");
        foreach(var studnet in sortedStudents)
        {
            Console.WriteLine(studnet.Name);
        }
    }
}