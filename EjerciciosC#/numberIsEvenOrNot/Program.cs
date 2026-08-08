

do
{
    Console.Write("Ingrese número o Ctrl + c para salir: ");
    var numberString = Console.ReadLine();
    try
    {
        var numberInt = int.Parse(numberString!);
        if (numberInt % 2 == 0) 
        {
            Console.WriteLine($"El número: {numberInt} es par.");
        }
        else
        {
            Console.WriteLine($"El número: {numberInt} es impar.");
        }
    }
    catch 
    {
        Console.WriteLine($"El número: {numberString} no es válido. Solo utilice carácteres numéricos");
    }
} while (true); 