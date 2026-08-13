using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var desks = ConsoleExtension.GetInt("Número de escritorios: ");
    float discount;
    if (desks < 5)
    {
        discount = 0.1f;
    }
    else if (desks < 10) 
    {
        discount = 0.2f;
    }
    else
    {
        discount = 0.4f;
    }

var valueToPay = desks *  650000M * (decimal)(1 - discount);

    Console.WriteLine($"El valor a pagar es..: {valueToPay:C2}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");