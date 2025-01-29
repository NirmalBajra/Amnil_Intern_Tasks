using System;

public interface IAnimal{
    void MakeSound();
    string GetSpecies();
}
//implementing dog class
class Dog : IAnimal{
    public void MakeSound(){
        Console.WriteLine("Dog barks");
    }
    public string GetSpecies(){
        return "Bull Dog";
    }
}
//implementing cat class
class Cat : IAnimal{
    public void MakeSound(){
        Console.WriteLine("Cat Meows");
    }
    public string GetSpecies(){
        return "Burmese";
    }
}