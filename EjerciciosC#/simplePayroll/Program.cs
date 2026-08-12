using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = ConsoleExtension.GetString("Ingrese nombre......................: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese número horas trabajadas.....: ");
    var hourValue = ConsoleExtension.GetDecimal("Ingrese valor hora..................: ");
    var salaryMinimun = ConsoleExtension.GetDecimal("Ingrese valor salario mínimo mensual: ");

    var Salary = (decimal)workHours * hourValue;
    if ((Salary < salaryMinimun))
    {
        Console.WriteLine($"Nombre..............................: {name}");
        Console.WriteLine($"Salario.............................: {salaryMinimun:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre..............................: {name}");
        Console.WriteLine($"Salario.............................: {Salary:C2}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");