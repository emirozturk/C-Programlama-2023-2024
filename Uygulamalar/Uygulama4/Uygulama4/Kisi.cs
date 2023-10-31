namespace Uygulama4;

public class Kisi
{
    public String ad { get; set; }
    public String soyad{ get; set; }
    public String sifre{ get; set; }
    public int yas{ get; set; }

    public Kisi(String ad, String soyad,String sifre)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.sifre = sifre;
    }

    public Kisi(string ad, string soyad, string sifre, int yas)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.sifre = sifre;
        this.yas = yas;
    }
}