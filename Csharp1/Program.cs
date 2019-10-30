using System;
using DynamicExpresso;


namespace Csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = "Hello World";
            double implicitDouble = 123.45;
            double explicitDouble = 123.45d;
            float explicitFloat = 123.45f;
            decimal explicitDecimal = 123.45m;
            uint unsignedInt = 100u;
            long longInteger = 100l;
            ulong unsignedLongInteger = 100ul;
            bool b = false;
            var interpreter = new Interpreter();
            var result = interpreter.Eval("8 /( 2 + 2)");
            Console.WriteLine(result);
        }
    }
}
