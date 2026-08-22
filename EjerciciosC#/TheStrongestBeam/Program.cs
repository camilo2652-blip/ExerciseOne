using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var beam = ConsoleExtension.GetString("Ingrese la viga: ");

    if (!IsValidBeam(beam))
    {
        Console.WriteLine("La viga está mal construida!");
    }
    else
    {
        var resistance = GetResistance(beam);
        var weight = CalculateWeight(beam);

        if (weight <= resistance)
        {
            Console.WriteLine("La viga soporta el peso!");
        }
        else
        {
            Console.WriteLine("La viga NO soporta el peso!");
        }
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions(
            "Deseas continuar [S]i, [N]o?.......: ",
            options);

    } while (!options.Any(x =>
        x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game over");


bool IsValidBeam(string beam)
{
    if (beam.Length == 0)
    {
        return false;
    }

    if (beam[0] != '%' && beam[0] != '&' && beam[0] != '#')
    {
        return false;
    }

    for (int i = 1; i < beam.Length; i++)
    {
        if (beam[i] != '=' && beam[i] != '*')
        {
            return false;
        }

        if (beam[i] == '*' && i + 1 < beam.Length && beam[i + 1] == '*')
        {
            return false;
        }
    }

    return true;
}


int GetResistance(string beam)
{
    if (beam[0] == '%')
    {
        return 10;
    }

    if (beam[0] == '&')
    {
        return 30;
    }

    return 90;
}


int CalculateWeight(string beam)
{
    var weight = 0;
    var sequence = 0;

    for (int i = 1; i < beam.Length; i++)
    {
        if (beam[i] == '=')
        {
            sequence++;
        }
        else
        {
            weight += sequence;
            weight += sequence * 2;
            sequence = 0;
        }
    }

    weight += sequence;

    return weight;
}