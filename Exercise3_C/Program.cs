using System;
using System.Collections.Generic;

namespace Exercise3_C
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> stringList = new List<String>();
            stringList.Add("Text");
            stringList.Add("Computer");
            stringList.Add("Automation");
            stringList.Add("Visual Studio");
            stringList.Add("Auto Parts");
            stringList.Add(" ");

            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(4);
            intList.Add(5);
            intList.Add(6);
            intList.Add(7);
            intList.Add(8);
            intList.Add(10);

            ClassB b = new ClassB();
            b.CompareStringLength("Development C#", "Development C#");
            Console.WriteLine("-----------------");
            b.Hello();
            Console.WriteLine("-----------------");
            b.SortList(stringList, "asc"); //Second parameter can be "asc" or "desc"
            Console.WriteLine("-----------------");
            b.RemoveDuplicates(intList);
            Console.WriteLine("-----------------");
            b.FilterList(stringList);
        }
    }
}
