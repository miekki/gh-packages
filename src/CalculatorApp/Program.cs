// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");


var calc = new Calculator.Lib.Calculator();

var result_add = calc.Add(4, 6);

Console.WriteLine($"Result for add 4+6={result_add}");

var result_sub = calc.Substruct(23, 5);

Console.WriteLine($"Result for subs 23-5={result_sub}");

var greetings = new Hello.Lib.Hello();

var result_hello = greetings.Greetings("Maciej");

Console.WriteLine(result_hello);
