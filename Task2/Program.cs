using System;
using MyNameSpace;

namespace Task2
{
    class ClassB : ClassA
    {
        public void GreetingUser()
        {
            Console.Write("Hello! Input your name: ");
            Console.WriteLine(this.HW(Console.ReadLine()));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassB classB = new ClassB();
            classB.GreetingUser();
        }
    }
}
