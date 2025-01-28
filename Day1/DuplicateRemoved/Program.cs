using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static List<string> listRemovedDuplicate(List<string> list)
    {
        return list.Distinct().ToList();
    }
    static void Main(string[] args)
    {
        List<string> Fruits = new List<string>{"Apple","Bannana","Mango","Mango","Apple","Orange","Bannana"};
        List<string> output = listRemovedDuplicate(Fruits);
        foreach(var fruit in output){
            Console.WriteLine(fruit+" ");
        }
    }
}