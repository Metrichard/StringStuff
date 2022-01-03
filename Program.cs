using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine() ?? "";
            string input2 = Console.ReadLine() ?? "";


            Console.WriteLine($"Normal string input: {input} and {input2}");

            Console.WriteLine("Now we add them together like: [ {input1}, + {input2}");

            string result = "[" + input.ToLiteral() + ", " + input2.ToLiteral() + "]";
            string result2 = "[".ToLiteral() + input.ToLiteral() + ", ".ToLiteral() + input2.ToLiteral() + "]".ToLiteral();

            Console.WriteLine($"Input with escaped characters: {result}");
            Console.WriteLine($"Or the whole thing as is: {result.ToLiteral()}");
            Console.WriteLine($"Or overboard like this: {result2}");
        }
    }

    public static class StringExtension
    {
        public static string ToLiteral(this string input)
        {
            using (var writer = new StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    return writer.ToString();
                }
            }
        }
    }

}
