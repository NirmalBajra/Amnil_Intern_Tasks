using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static List<string> listRemovedDuplicate(List<string> fruitsList)
    {
        var uniqueList = new List<string>();
        foreach(var item in fruitsList)
        {
            if(!uniqueList.Contains(item))
            {   
                uniqueList.Add(item);
            }
        }
        return uniqueList;
    }
    static void Main(string[] args)
    {
        List<string> Fruits = new List<string>{"Apple","Bannana","Mango","Mango","Apple","Orange","Bannana"};
        List<string> output = listRemovedDuplicate(Fruits);
        foreach(var fruits in output){
            Console.WriteLine(fruits+" ");
        }
    }
}