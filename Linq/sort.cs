using System;
using System.Linq;
using System.Collections.Generic;

public static class SortStudentsNameExtension
{
    public static List<Student> SortStudentName(this List<Student> students)
    {
        return students.OrderByDescending(s => s.Name).ToList();
    }
}
