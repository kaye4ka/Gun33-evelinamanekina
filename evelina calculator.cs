class Program
{
    static void Main(string[] args)
    {
        var s1 = Console.ReadLine();
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number!");
            return;
        }
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number!");
            return;
        }
        var S = Console.ReadLine();
        var boolVar = true;
        if (S.Length == 0||S.Length > 1 && !boolVar)
        {
            Console.WriteLine("Wrong sign");
            return;
        }
        switch (S[0])

        {
            case '+':
                Console.WriteLine("Result of {0}+{1}={2}");
                break;
            case '-':
                Console.WriteLine("Result of {0}-{1}={2}");
                break;
            case '*':
                Console.WriteLine("Result of {0}*{1}={2}");
                break;
            case '/':
                Console.WriteLine("Result of {0}/{1}={2}");
                break;
            case '%':
                Console.WriteLine("Result of {0}%{1}={2}");
                break;
            default:
                Console.WriteLine("Wrong sign");
                break;
        }
        Console.WriteLine("Result of {0}+{1}={2},a,b,a+b");
        Console.WriteLine("Result of {0}-{1}={2},a,b,a-b");
        Console.WriteLine("Result of {0}*{1}={2},a,b,a*b");
        Console.WriteLine("Result of {0}/{1}={2},a,b,a/b");
        Console.WriteLine("Result of {0}%{1}={2},a,b,a%b");
    }
}