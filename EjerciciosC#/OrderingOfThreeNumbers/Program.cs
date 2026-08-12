using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 3 números diferentes");
    var a = ConsoleExtension.GetInt("Ingresa primer número: ");
    var b = ConsoleExtension.GetInt("Ingresa segundo número: ");
    var c = ConsoleExtension.GetInt("Ingresa tercer número: ");

    if (a==b)
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar");
        continue;
    }
    if (b == c || a==c)
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar");
        continue;
    }

    if (a>b && a>c)
    {
        if (b>c)
        {
            Console.WriteLine($"El mayor es {a}, el medio es {b}, el menor es {c}");
        }
        else
        { Console.WriteLine($"El mayor es {a}, el medio es {c}, el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es {b}, el medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, el medio es {c}, el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mayor es {c}, el medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, el medio es {b}, el menor es {a}");
        }
    }
do
{
    answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [n]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;
Console.WriteLine("Game over");