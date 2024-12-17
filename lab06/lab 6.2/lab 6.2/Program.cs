using lab_6._2;
using System.Collections;
using System.Collections.Generic;
namespace lab_6._2;
    internal class Program
    {
    static void Main(string[] args)
    {
        //Hiển thị dữ liệu
        Console.WriteLine("hiển thị danh sách:");
        Hashtable week = new Hashtable();

        week.Add("1", "MONDAY");
        week.Add("2", "TUEDAY");
        week.Add("3", "WEDDAY");
        week.Add("4", "THUDAY");
        week.Add("5", "FRIDAY");
        week.Add("6", "SATDAY");
        week.Add("7", "SUNDAY");
        week.Add("8", "0DAY");

        Console.WriteLine("----------------");
        Console.WriteLine("hiển thị ngay trong tuan");
        foreach (var key in week.Keys)
        {
            Console.WriteLine("key:" + key + " \t value: " + week[key]);
        }
        Console.WriteLine("----------------");
        Console.WriteLine("hiển thị thông báo có TUEDAY");
        if (week.ContainsValue("TUEDAY"))
        {
            Console.WriteLine("co tueday");
        }
        else
        {
            Console.WriteLine("eo cos");
        }

        Console.WriteLine("----------------");

    }
    }


