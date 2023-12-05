class Program
{
    public static int fonk(int a,int b)
    {
        return a + b;
    }
    public static void Main(string[] args)
    {
        int a = 342;
        int b = 4398;
        Console.WriteLine(fonk(a, b));
        Func<int,int,int> fonk2 = (a, b) => a + b;
        Console.WriteLine(fonk2(a,b));
    }
}