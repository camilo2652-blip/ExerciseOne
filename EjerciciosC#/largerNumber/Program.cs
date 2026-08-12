
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese tres números diferentes:");
    var a = ConsoleExtension.GetInt("ingresse primer número :");
    var b = ConsoleExtension.GetInt("ingresse segundo número:");
    var c = ConsoleExtension.GetInt("ingresse tercer número :");

    if (a > b && a > c)
    {
        Console.WriteLine($"El número mayor es: {a}");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"El número mayor es: {b}");
    }
    else
    {
        Console.WriteLine($"El número mayor es: {c}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");

