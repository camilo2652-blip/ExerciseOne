using Shared;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("*** DATOS DE ENTRADA ***");
    var CC = ConsoleExtension.GetDecimal("Costo de compra ($)....................................................: ");
    var TP = ConsoleExtension.GetValidOptions("Tipo de producto [P]erecedero, [N]o precedero.....................: ", ["p","n"]);
    var TC = ConsoleExtension.GetValidOptions("Tipo de conservacion [F]rio, [A]mbiente...........................: ", ["f", "a"]);
    var PC = ConsoleExtension.GetInt("Perido de conservación (días)..............................................: ");
    var PA = ConsoleExtension.GetInt("Perido de almacenamiento (días)............................................: ");
    var VOL = ConsoleExtension.GetInt("Volumen (litros)..........................................................: ");
    var MA = ConsoleExtension.GetValidOptions("Medio de almacenamiento [N]evera, [C]ongelador,[E]estanteria, [G]uacal: ", ["n","c","e","g"]);
    Console.WriteLine("*** CÁLCULOS ***");
    var CA= GetCostoALmacenamiento(CC, TC, PC, VOL);
    var PDP = GetPorcentajeDepreciacionDelProducto(PA);
    var BR_V = GetValorVenta(TP, CC, CA, PDP);
    var CE = GetCostoExhibicion(TP, TC, MA);

    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");

decimal GetCostoExhibicion(string? tP, string? tC, string? mA)
{
    throw new NotImplementedException();
}

decimal GetValorVenta(string? tP, decimal cC, decimal cA, float pDP)
{
    throw new NotImplementedException();
}

float GetPorcentajeDepreciacionDelProducto(int pA)
{
    throw new NotImplementedException();
}

decimal GetCostoALmacenamiento(decimal CC, string? TC, int PC, int VOL)
{
    throw new NotImplementedException();
}

Console.WriteLine("Game over");

