using System;
using DynamicExpresso;
using System.Text.RegularExpressions;


namespace Csharp1
{
    class Program
    {
        static void Main(string[] args)


        {
           // dongchenModel dc = new dongchenModel();
           // Console.WriteLine(dc.num());
            while (true)
            {
                Console.WriteLine("Please input your math function (+,-,*,/)");
                var mathFunction = Console.ReadLine();
                if (!Regex.IsMatch(mathFunction, @"^[\+\-\*\/]{1}$"))
                {
                    Console.WriteLine("Please input a valid math function");
                    continue;

                }
                Console.WriteLine("Please input your first number");
              
                var firstNumber = Console.ReadLine();
                if (!Regex.IsMatch(firstNumber, @"^-?[0-9][0-9,\.]+$"))
                {
                    Console.WriteLine("Please input a valid number");
                    continue;
                }
                Console.WriteLine("Please input your second number");
                var secondNumber = Console.ReadLine();
                if (!Regex.IsMatch(secondNumber, @"^-?[0-9][0-9,\.]+$"))
                {
                    Console.WriteLine("Please input a valid number");
                    continue;
                }
                var result = "";
                Interpreter interpreter = new Interpreter();
                try
                {
                    result = "Your answer is: " + interpreter.Eval(firstNumber+ mathFunction+ secondNumber);
                }
                catch (Exception e)
                {
                    result = "Oops, something wrong with your input: \n";
                }

                Console.WriteLine(result);
            }
          
        }
        static int get(int a,int b)
        {
            return 1;
        }
    }
}
