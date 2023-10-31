namespace Uygulama4;

public class Login
{
    private static List<Kisi> kisiListesi;

    public Login()
    {
        kisiListesi = new List<Kisi>()
        {
            new Kisi("Emir","Öztürk","123",54),
            new Kisi("İshak","Doğanay","38",16),
            new Kisi("Serdest","Onat","72",18),
            new Kisi("Abdullah","Vural","81",20),
        };
    }

    public int CheckLogin(Kisi k)
    {
        var sonuc = kisiListesi.FirstOrDefault(x=>x.ad==k.ad && x.soyad == k.soyad);
        return Convert.ToInt32(sonuc != null && sonuc.yas >= 18 && sonuc.sifre == k.sifre);
    }
}