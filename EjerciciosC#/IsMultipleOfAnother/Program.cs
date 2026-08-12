using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 2 números");
    var a = ConsoleExtension.GetInt("Ingresa primer número: ");
    var b = ConsoleExtension.GetInt("Ingresa segundo número: ");
 
    if (b % a == 0) 
    {
        Console.WriteLine($"{a} es multiplo de {b}");
    }
    else
    {
        Console.WriteLine($"{a} no es multiplo de {b}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");