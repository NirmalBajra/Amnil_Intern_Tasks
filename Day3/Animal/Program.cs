class Program{
    public static void Main(string[] args){
        //Creating Dog Object
        Dog dogObj = new Dog();
        dogObj.MakeSound(); //calling MakeSound
        Console.WriteLine($"Dog Species: {dogObj.GetSpecies()}");

        //Creating Cat Object
        Cat catObj = new Cat();
        catObj.MakeSound(); //calling MakeSound
        Console.WriteLine($"Cat Species: {catObj.GetSpecies()}");
    }
}