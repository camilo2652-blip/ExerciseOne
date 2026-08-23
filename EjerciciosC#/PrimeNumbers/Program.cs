
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Cuántos números primos quieres: ");
    var primes = GetPrimes(n);
    foreach (var prime in primes)
    {
        Console.Write($"{prime,10:N0}");
    }
    Console.WriteLine();
    Console.WriteLine($"La sumatoria es: {primes.Sum(),10:N0}");
    Console.WriteLine($"El promedio es.: {primes.Average(),10:N0}");
    Console.WriteLine();

    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [n]o?: ", options);
        Console.WriteLine();
        Console.WriteLine();
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");

List<int> GetPrimes(int n)
{
    var primes = new List<int>();
    var num = 2; 
    while (primes.Count < n)
    {
        if (MyMath.IsPrime(num))
        {
            primes.Add(num);
        }
        num++;
    }
    return primes;
}







