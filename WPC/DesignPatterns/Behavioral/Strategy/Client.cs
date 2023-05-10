using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC.DesignPatterns.Behavioral.Strategy.Interpreter;

namespace WPC.DesignPatterns.Behavioral.Strategy
{
    public class Client
    {
        public static void Execute()
        {
            var calculator = new Calculator();

            while (true)
            {
                var line = Console.ReadLine();
                var split = line.Split(' ');
                if (split.Length < 3)
                    continue;

                calculator.Strategy = GetStrategy(split[1]);

                if (float.TryParse(split[0], out var a) && float.TryParse(split[2], out var b))
                {
                    Console.WriteLine(calculator.Operate(a, b));
                }


                var mathObject = line.Interpret();
                Console.WriteLine(  mathObject.Func(mathObject.A, mathObject.B) );
            }




        }



        private static ICalcStrategy? GetStrategy(string v)
        {
            switch (v)
            {
                case "+":
                    return new PlusStrategy();
                case "-":
                    return new MinusStrategy();
                case "*":
                    return new MultiplyStrategy();
                case "/":
                    return new DivideStrategy();
                default:
                    return null;
            }
        }
    }
}
