using Uygulama8;

class Program
{
    public static void Main(string[] args)
    {
        List<Kisi> kisiListesi = new List<Kisi>()
        {
            new() { AdSoyad = "Emir Öztürk", Boy = 123 },
            new() { AdSoyad = "Abdullah Vural", Boy = 124 },
            new() { AdSoyad = "Emir Tokat", Boy = 125 },
            new() { AdSoyad = "Damla Çakır", Boy = 126 },
            new() { AdSoyad = "Asya Mirzaoğlu", Boy = 127 },
        };
        var sonuc = kisiListesi
            .Select(x => new Kisi{ AdSoyad = x.AdSoyad.ToUpper(),Boy = x.Boy});
        foreach (var eleman in sonuc) Console.WriteLine(eleman);
    }
}