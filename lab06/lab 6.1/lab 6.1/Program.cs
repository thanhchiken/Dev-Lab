using lab_6._1;
using System.Collections;
using System.Collections.Generic;
namespace lab_6._1;
internal class Program
{
    static void Main(string[] args)
    {
        //tạo 10 quyển
        List<Book> books = new List<Book>
        {
            new Book { Id = "B001", Title = "C# ", Author = "John Doe", Publisher = "Nhi Đong", Year = 2024, Price = 25.99m },
            new Book { Id = "B002", Title = "Java ", Author = "Jane Smith", Publisher = "CodePress", Year = 2014, Price = 30.50m },
            new Book { Id = "B003", Title = "Python", Author = "James Brown", Publisher = "Nhi Đong", Year = 2022, Price = 20.75m },
            new Book { Id = "B004", Title = "Data ", Author = "Michael Scott", Publisher = "EduBooks", Year = 2014, Price = 15.99m },
            new Book { Id = "B005", Title = "Algorithms ", Author = "Thomas H. Cormen", Publisher = "MIT", Year = 2019, Price = 40.00m },
            new Book { Id = "B006", Title = "Clean Code", Author = "Robert C. Martin", Publisher = "Prentice", Year = 2008, Price = 35.99m },
            new Book { Id = "B007", Title = "Design ", Author = "Erich Gamma", Publisher = "Addison", Year = 1994, Price = 45.50m },
            new Book { Id = "B008", Title = "Pragmatic ", Author = "Andy Hunt", Publisher = "Addison", Year = 1999, Price = 38.00m },
            new Book { Id = "B009", Title = "Introduction", Author = "Cormen et al.", Publisher = "MIT", Year = 2021, Price = 55.00m },
            new Book { Id = "B010", Title = "Effective", Author = "Joshua Bloch", Publisher = "Addison", Year = 2018, Price = 29.99m }
        };
        // in all danh sách
        Console.WriteLine("danh sach book:");
        foreach (var b in books)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine("-------------------------");
        // tăng dần theo giá 
        var sortedList = books.OrderBy(b => b.Price).ToList();
        Console.WriteLine("Danh sách sinh viên sắp xếp tăng dần theo giá: "); 
        foreach (var b in sortedList)
        {
            Console.WriteLine(b);

        }
        Console.WriteLine("-------------------------");
        var book2014 = books.Where(b => b.Year == 2014);
        Console.WriteLine("Danh sách sinh viên 2014: ");
        foreach (var b in book2014)
        {
            Console.WriteLine(b);
        }

        Console.WriteLine("-------------------------");
        books.RemoveAll(b => b.Publisher == "Nhi Đong");
        Console.WriteLine("Danh sách sinh viên ko co nhi dong ");
        foreach (var b in books)
        {
            Console.WriteLine(b);
        }



    }
}