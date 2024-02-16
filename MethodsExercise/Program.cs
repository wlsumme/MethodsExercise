
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
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite car?");
            var car = Console.ReadLine();
            Console.WriteLine($" I'm {name}. Today i saw a {animal}, taking a {color} poop on a fancy {car}.");

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










