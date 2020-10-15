using System;

namespace ReadAndWriteData
{
    public class Data
    {
        public string name { get; set; }
        public int age { get; set; }
        public void Print()
        {
            Console.WriteLine("my name is:{0}, and my age is:{1}", name, age);
        }
    }
}
