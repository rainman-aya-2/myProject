using algorithm;
using ReadAndWriteData;
using System;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 tar = new Class1();
            tar.fun();
            Console.WriteLine("Hello World!");
            Data girl = new Data();
            girl.name = "Ayala";
            girl.age = 20;
            girl.Print();
            
        }
    }
}
