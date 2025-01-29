class Person{
    public string Name { get; set;}
    public int Age { get; set;}
    public void Introduce(){
        Console.WriteLine($"My Name is {Name}. I am {Age} years old.");
    }
}
class Program{
    public static void Main(string[] args){
        Person person = new Person {Name ="Nirmal",Age = 21};
        person.Introduce();
    }
}