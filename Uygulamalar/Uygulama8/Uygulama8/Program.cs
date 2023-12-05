class Program
{
    public static int Uygulayici(int a,int b,Func<int,int,int> fonk)
    {
        return fonk(a,b);
    }
    public static void Main(string[] args)
    {
        int a = 342;
        int b = 4398;
        Console.WriteLine(Uygulayici(a,b,(x,y)=>x+y));
        Console.WriteLine(Uygulayici(a,b,(x,y)=>x*y));
    }
}