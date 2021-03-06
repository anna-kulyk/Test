﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> md = new MyDictionary<string, string>();
            md.AddItem("книга", "book");
            md.AddItem("ручка", "pen");
            md.AddItem("солнце", "sun");
            md.AddItem("яблоко", "apple");
            md.AddItem("стол", "table");
            Console.WriteLine(md.Count);
            Console.WriteLine(new string('-', 10));
            foreach (var item in md)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(md["стол"]);
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(md["стул"]);
        }
    }
}
