using Shared;


do
{
    Console.WriteLine("Ingrese 2 números");
    var a = ConsoleExtension.GetInt("Ingresa primer número: ");
    var b = ConsoleExtension.GetInt("Ingresa segundo número: ");
 
    if (b % a == 0) 
    {
        Console.WriteLine($"{a} es multiplo de {b}");
    }
    else
    {
        Console.WriteLine($"{a} no es multiplo de {b}");
    }

}while (true);
