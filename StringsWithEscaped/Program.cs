using System;
using System.IO;
using System.CodeDom;
using System.CodeDom.Compiler;

namespace Main
{
    public static void Main(String[] args){
        string input = Console.ReadLine() ?? "";
        string input2 = Console.ReadLine() ?? "";


        Console.WriteLine($"Normal string input: {input} and {input2}");

        Console.WriteLine("Now we add them together like: [ {input1}, + {input2}");

        string result = "[" + input.ToLiteral() + ", " + input2.ToLiteral() + "]";

        Console.WriteLine($"Input with escaped characters: {result}");
    }
    
    
}



