using System;

namespace csharpbasics2
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("MyMethod just got called");
        }
        static void TestMethod(string fname)
        {
            Console.WriteLine(fname + "refsnes")
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyMethod();
            //a method is a block of code which only runs when it is called
            //methods are used to perform actions, they are known as functions 
            //a method is defined with the name of the method, followed by ()
            //Main() is a premade method, Main is the name of the method
            //static means that the method belongs to the program class and is not an object of program class
            //void means that this method does not have a return value
            //if you do not want a return value make it void


            //MEthod parameters 
            //parameters and arguments
            //info can be passed to methods as a paramater which act as vars inside the method
            TestMethod("hi")
        }
    }
}
