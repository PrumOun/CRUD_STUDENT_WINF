using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListStudent;
public delegate void StudentEventHandler(object? sender, People stud);
public class People{
    public int No { get; set; } = default!;
    public String Name { get; set; } = default!;
    public int Age { get; set; } = default!;
    public String Gender { get; set; } = default!;
    public String Info => $"Name: {Name}, Genfer: {Gender}, Age: {Age},";
    //public static String Separate { get; set; } = "/";
    //private static int count = 0;
    public static People? createInstance(String data)
    {
        String[] arr = data.Split("/");
        if (arr.Length < 4) return null;
        if (int.TryParse(arr[0], out int no) == false) return null;
        if (int.TryParse(arr[3], out int age) == false) return null;
        //no = ++count;
        return new People()
        {
            No = no,
            Name = arr[1].Trim(),
            Gender = arr[2].Trim(),
            Age = age

        };
    }

}

