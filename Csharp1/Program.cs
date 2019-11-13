using System;
using DynamicExpresso;
using System.Text.RegularExpressions;


namespace Csharp1
{
    class Program
    {
        static void Main(string[] args)


        {
          var arr = new[]
                {
                   @" ▄████▄   ▄▄▄       ██▓     ▄████▄   █    ██  ██▓    ▄▄▄     ▄▄▄█████▓ ▒█████   ██▀███ ",
                   @"▒██▀ ▀█  ▒████▄    ▓██▒    ▒██▀ ▀█   ██  ▓██▒▓██▒   ▒████▄   ▓  ██▒ ▓▒▒██▒  ██▒▓██ ▒ ██▒",
                   @"▒▓█    ▄ ▒██  ▀█▄  ▒██░    ▒▓█    ▄ ▓██  ▒██░▒██░   ▒██  ▀█▄ ▒ ▓██░ ▒░▒██░  ██▒▓██ ░▄█ ▒",
                   @"▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒██░    ▒▓▓▄ ▄██▒▓▓█  ░██░▒██░   ░██▄▄▄▄██░ ▓██▓ ░ ▒██   ██░▒██▀▀█▄  ",
                   @"▒ ▓███▀ ░ ▓█   ▓██▒░██████▒▒ ▓███▀ ░▒▒█████▓ ░██████▒▓█   ▓██▒ ▒██▒ ░ ░ ████▓▒░░██▓ ▒██▒",
                   @"░ ░▒ ▒  ░ ▒▒   ▓▒█░░ ▒░▓  ░░ ░▒ ▒  ░░▒▓▒ ▒ ▒ ░ ▒░▓  ░▒▒   ▓▒█░ ▒ ░░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░",
                   @"  ░  ▒     ▒   ▒▒ ░░ ░ ▒  ░  ░  ▒   ░░▒░ ░ ░ ░ ░ ▒  ░ ▒   ▒▒ ░   ░      ░ ▒ ▒░   ░▒ ░ ▒░",
                   @"░          ░   ▒     ░ ░   ░         ░░░ ░ ░   ░ ░    ░   ▒    ░      ░ ░ ░ ▒    ░░   ░ ",
                   @"░ ░            ░  ░    ░  ░░ ░         ░         ░  ░     ░  ░            ░ ░     ░     ",
                   @"░                          ░                                                            "


               };
                foreach (string line in arr)
                    Console.WriteLine(line);
            while (true)
            {
                

                Console.WriteLine("Please input your math function (+,-,*,/,%), input \"Exit\" to quit");
                var mathFunction = Console.ReadLine();
                if (!Regex.IsMatch(mathFunction, @"^[\+\-\*\/\%]$"))
                {
                    if (mathFunction == "Exit")
                    {
                        Console.WriteLine("Exit program");
                        break;
                    }
                    Console.WriteLine("Please input a valid math function");
                    continue;

                }
                Console.WriteLine("Please input your first number");
              
                var firstNumber = Console.ReadLine();
                if (!Regex.IsMatch(firstNumber, @"^\-?\d*\.?\d+$"))
                {
                    Console.WriteLine("Please input a valid number");
                    continue;
                }
                Console.WriteLine("Please input your second number");
                var secondNumber = Console.ReadLine();
                if (!Regex.IsMatch(secondNumber, @"^\-?\d*\.?\d+$"))
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
                catch(DivideByZeroException e)
                {
                    result = "Oops, you are trying to divide by zero";
                }
                catch (Exception e)
                {
                    result = "Oops, something wrong with your input, Here is your error message: "+e.Message;
                }

                Console.WriteLine(result);
            }
          
        }
    }
}
