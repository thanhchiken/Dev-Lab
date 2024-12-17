using lab_6._3;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
namespace lab_6._3;
internal class Program
{
    static void Main(string[] args)
    {
        //tạo 10 quyển
        List<Car> cars = new List<Car>
        {
            new Car {name = "abc", Color = "White"},
            new Car {name = "qwe", Color = "Blue"},
            new Car {name = "qaz", Color = "Green"},
            new Car {name = "wsx", Color = "Yellow"},
            new Car {name = "edc", Color = "Red"},
            new Car {name = "qsc", Color = "Black"},
            new Car {name = "esz", Color = "Violet"},
            new Car {name = "qes", Color = "Pink"},
            new Car {name = "zcs", Color = "Brown"},
            new Car {name = "axd", Color = "Beige"},
        };

        Console.WriteLine("Danh sách xe ");
        foreach (var C in cars) {
            Console.WriteLine(C);
        }

        Console.WriteLine("-------------------------");
        cars.RemoveAll(C => C.Color == "Red");
        Console.WriteLine("Danh sách xe ko co mau red ");
        foreach (var C in cars)
        {
            Console.WriteLine(C);
        }

    }
}