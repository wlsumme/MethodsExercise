
using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        
        {
            MadLib();

            var add = Add(2, 4);
            Console.WriteLine(add);

            int mult = Multiply(10, 2);
            Console.WriteLine(mult);

            int sub = Subtract(60, 23);
            Console.WriteLine(sub);

            int div = Divide(1000, 50);
            Console.WriteLine(div);




            

            

            
        }
        public static void MadLib()
        {
            Console.WriteLine("Exercise 1\n");
            Console.WriteLine("What is you name?");
            var name = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("\nWhat is your favorite color?");
            var color = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("\nWhat is your favorite animal?");
            var animal = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("\nWhat is your favorite car?");
            var car = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine($"\n\n Ok so your name is {name}. hopefully you have  COOL {car} one day.");
            Thread.Sleep(2000);
            Console.WriteLine($" But if you dont then you should try getting a {color} {animal}.");
            Thread.Sleep(2000);
            Console.WriteLine($" Wouldnt that be cool.");
            Thread.Sleep(2000);

            Console.WriteLine("\n\nExercise 2\n");


        }
        public static int Add(int num1, int num2)
        
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        
        {
            return num1 * num2;
        }
        public static int Subtract(int num1, int num2) 
        
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2) 
        {
            return num1 / num2;

        }
   






       }
}










