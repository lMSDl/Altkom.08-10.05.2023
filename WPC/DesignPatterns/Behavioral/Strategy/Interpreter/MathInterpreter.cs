using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Strategy.Interpreter
{
    internal static class MathInterpreter
    {
        public static MathObject Interpret(this string input)
        {
            var split = input.Split(' ');
            if (split.Length < 3)
                return null;


            if (float.TryParse(split[0], out var a) && float.TryParse(split[2], out var b))
            {
                var result = new MathObject
                {
                    A = a,
                    B = b,
                    Func = GetFunc(split[1])
                };
                return result;
            }

            return null;
        }



        private static Func<float, float, float> GetFunc(string v)
        {
            switch (v)
            {
                case "+":
                    return (a, b) => a + b;
                case "-":
                    return (a, b) => a - b;
                case "*":
                    return (a, b) => a * b;
                case "/":
                    return (a, b) => a / b;
                default:
                    return null;
            }
        }
    }
}
