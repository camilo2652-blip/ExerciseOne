using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Cuántos números desea: ");
    int sum = 0;

    int i = 1;
    while (i <= n)
    {
        Console.Write($"{i}\t");
            sum += i;
        i++;
    }

    //for (int i = 1; i <= n; i++)
    //{
    //    Console.Write($"{i}\t");
    //    sum += i;
    //}

    Console.WriteLine();
    Console.WriteLine($"La suma es....: {sum,20:N0}");
    Console.WriteLine($"El promedio es: {(decimal)sum /n,20:N2}"); //al castear saca lso decimales

    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");