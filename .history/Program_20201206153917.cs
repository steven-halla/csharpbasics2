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
            Console.WriteLine(fname + "jonny");
        }

        static void Country(string country = "norway")
        {
            Console.WriteLine(country);
        }

        static void Info(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        static int YourMethod(int x)
        {
            return 5 + x;
        }

        static void AMethod

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
            TestMethod("hi ");
            TestMethod("bye ");
            TestMethod("hello ");
            //When a parameter is passed to the method, it is called an argument. fname is a parameter
            //while hi bye and hello are arguments 


            //notice how the method that doesn't have an argument gets it filled in with norway
            //this is bc we passed it in as an argument so any blanks will equal that
            //and if its prefilled then norway will not replace it
            //norway is the default value, country (not Country() ) is an optional parameter 
            Country("Sweden");
            Country("India");
            Country();
            Country("USA");

            //this is how we pass in multiple parameters 
            Info("Liam", 5);
            Info("Jenny", 8);
            Info("Anja", 31);

            //this is for return values , if you check instead of using the keyword "void" we instead
            //use the keyword "int"
            Console.WriteLine(YourMethod(3));
        }
    }
}
