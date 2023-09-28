namespace ConsoleApp3;

public class Cat : IAnimal
{
    public string Name { get; set; }
    public void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}