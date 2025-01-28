using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //Male and Female Const declared
    private const string Male = "Male";
    private const string Female = "Female";

    static void Distinguish(List<Person> personList)
    {
        
        var malePerson = new List<Person>();
        var femalePerson = new List<Person>() ;
        
        //checking gender male and female and adding to the malePerson and femalePerson List
        foreach(var Person in personList)
        {
            if(Person.Gender == Male){
                malePerson.Add(Person);
            }else if(Person.Gender == Female)
            {
                femalePerson.Add(Person);
            }
        }
        Console.WriteLine("Male Person:");
        foreach(var m in malePerson){
            Console.WriteLine($"ID: {m.Id}, Name: {m.Name}, Gender: {m.Gender}");
        }
        Console.WriteLine("Female Person:");
        foreach(var m in femalePerson){
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