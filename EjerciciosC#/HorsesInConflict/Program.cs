using Shared;

var ubicaciones = ConsoleExtension.GetString(
    "Ingrese ubicación de los caballos: ")!;

var caballos = ubicaciones.Split(',');

foreach (var caballo in caballos)
{
    var posicion = caballo.Trim().ToUpper();

    char columna = posicion[0];
    int fila = int.Parse(posicion.Substring(1));

    Console.Write($"Analizando Caballo en {fila}{columna} =>");

    var conflictos = new List<string>();

    foreach (var otroCaballo in caballos)
    {
        var otraPosicion = otroCaballo.Trim().ToUpper();

        if (posicion == otraPosicion)
        {
            continue;
        }

        char otraColumna = otraPosicion[0];
        int otraFila = int.Parse(otraPosicion.Substring(1));

        int diferenciaColumnas = Math.Abs(columna - otraColumna);
        int diferenciaFilas = Math.Abs(fila - otraFila);

        if ((diferenciaColumnas == 1 && diferenciaFilas == 2) ||
            (diferenciaColumnas == 2 && diferenciaFilas == 1))
        {
            conflictos.Add($"{otraFila}{otraColumna}");
        }
    }

    conflictos = conflictos
        .OrderByDescending(x => int.Parse(x.Substring(0, 1)))
        .ToList();

    foreach (var conflicto in conflictos)
    {
        Console.Write($" Conflicto con {conflicto}");
    }

    Console.WriteLine();
}