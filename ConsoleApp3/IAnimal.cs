namespace ConsoleApp3;

public interface IAnimal
{
    string Name { get; set; }

    public void MakeSound()
    {
        Console.WriteLine("IAnimal BOO");
    }
}