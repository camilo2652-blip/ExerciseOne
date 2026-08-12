
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var number = ConsoleExtension.GetInt("Ingrese número entero: ");

    
        if (number % 2 == 0) 
        {
            Console.WriteLine($"El número: {number} es par.");
        }
        else
        {
            Console.WriteLine($"El número: {number} es impar.");
        }
    
    do 
    {
      answer = ConsoleExtension.GetValidOptions("Desea continuar [S]í, [N]O?: ", options);
    }while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");