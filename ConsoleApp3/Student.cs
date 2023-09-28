namespace ConsoleApp3;
public class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }

    public int CompareTo(Student other)
    {
        if (this.Name.CompareTo(other.Name) == 0)
        {
            if (this.Age.CompareTo(other.Age) == 0)
            {
                return this.Grade.CompareTo(other.Grade);
            }
            else
            {
                return this.Age.CompareTo(other.Age);
            }
        }
        else
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}

public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Price { get; set; }

    public int CompareTo(Book other)
    {
        if (this.Title.CompareTo(other.Title) == 0)
        {
            if (this.Author.CompareTo(other.Author) == 0)
            {
                return this.Price.CompareTo(other.Price);
            }
            else
            {
                return this.Author.CompareTo(other.Author);
            }
        }
        else
        {
            return this.Title.CompareTo(other.Title);
        }
    }
}