class main
{
    /*
    static int deger = 0;
    static object kilit = false;
    static void Fonk(object i)
    {
        lock(kilit)
        {
            var temp = deger;
            temp = temp + 1;
            Thread.Sleep(100);
            deger = temp;
            Console.WriteLine($"{i}. Paralel işlem");
        }
    }
        static int deger = 0;
       static Mutex m = new Mutex();
       
       static void Fonk(object i)
       {
       m.WaitOne();
       var temp = deger;
       temp = temp + 1;
       Thread.Sleep(100);
       deger = temp;
       Console.WriteLine($"{i}. Paralel işlem");
       m.ReleaseMutex();
       }
    */
    static int deger = 0;
    static Semaphore s = new Semaphore(3,8);

    static void Fonk(object i)
    {
        s.WaitOne();
        Thread.Sleep(500);
        Console.WriteLine($"{i}. Paralel işlem");
        s.Release();
    }
    
    public static void Main(string[] args)
    {
        var threadListesi = new List<Thread>();
        for (int i = 0; i < 100; i++)
        {
            Thread th = new Thread(Fonk);
            th.Start(i);
            threadListesi.Add(th);
        }
        threadListesi.ForEach(x=>x.Join());
        
        Console.WriteLine($"Uygulama bitti {deger}");
    }
}