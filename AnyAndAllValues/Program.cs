class Program
{
    static void Main(string[] args)
    {
        //All method
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var areAllEvenNumbers=numbers.All(x=>x%2==0);
        Console.WriteLine($"allEvenNumbers:{areAllEvenNumbers}");
        //Any method
        var anyOddNumber=numbers.Any(x=>x%2==1);
        Console.WriteLine($"anyOddNumber :{anyOddNumber}");
    }
}
