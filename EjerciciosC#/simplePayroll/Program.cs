using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = ConsoleExtension.GetString("Ingrese nombre: ");
    var worHours = ConsoleExtension.GetFloat("Ingrese número horas trabajadas: ");
    var hourValue = ConsoleExtension.GetDecimal("Ingrese valor hora: ");
    var salaryMinimun = ConsoleExtension.GetDecimal("Ingrese valor salario mínimo mensual: ");

    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");