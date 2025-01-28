using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Person
    {
        public int Id{ get; set;}
        public string Name{ get; set;}
        public string Gender{ get; set;}
    }

    static void Distinguish(List<Person> personList)
    {
        List<Person> male = new List<Person>();
        List<Person> female = new List<Person>();
        
        foreach(var Person in personList)
        {
            if(Person.Gender.Contains("Male")){
                male.Add(Person);
            }else if(Person.Gender.Contains("Female"))
            {
                female.Add(Person);
            }
        }
        Console.WriteLine("Male Person:");
        foreach(var m in male){
            Console.WriteLine($"ID: {m.Id}, Name: {m.Name}, Gender: {m.Gender}");
        }
        Console.WriteLine("Female Person:");
        foreach(var m in female){
            Console.WriteLine($"ID: {m.Id}, Name: {m.Name}, Gender: {m.Gender}");
        }
    }
    static void Main(string [] args){
        var personList = new List<Person>
        {
            new Person{Id = 1, Name= "Ravi", Gender= "Male"},
            new Person{Id = 2, Name= "Sita", Gender= "Female"},
            new Person{Id = 3, Name= "Ram", Gender= "Male"},
            new Person{Id = 4, Name= "Kabita", Gender= "Female"},
            new Person{Id = 5, Name= "Nisha", Gender= "Female"},
            new Person{Id = 6, Name= "Rishab", Gender= "Male"},
        };
        Distinguish(personList);
    }
}