class Program
{
    public static string[] Metot(List<int> sayilar)
    {
        //Liste içerisindeki 50den büyük sayıların
        //5. elemandan 10. elemana kadar olanlarını alan ve bu sayıların
        //karelerini küçükten büyüğe sıralayıp bir string dizisi olarak
        //döndüren metot
        
    }
    public static void Main(string[] args)
    {
        var sayilar = new List<int>() {0,-1,60,8,-1,15,2,9,2,84,3,30,7,48,31,47,38,2,42,66,31,28,43,28,79,48,52,96,17,76,55,20,18,57,44,56,36,51,58,74,20,97,59,53,53,97,26,24,92,74,56,58,64,43,-1,62,94,48,47,23,-1,89,86,81,58,72,79,51,25,56,94,57,80,-1,7,31,59,34,100,-1,71};
        var sonuc = Metot(sayilar);
        foreach(var eleman in sonuc)Console.WriteLine(eleman);
    }
}