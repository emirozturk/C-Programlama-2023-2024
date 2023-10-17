using System.Runtime.CompilerServices;

namespace Uygulama3;

public class DepremKayitListesi
{
    private List<DepremKayit> liste;

    public DepremKayitListesi(string dosyaYolu)
    {
        liste = new List<DepremKayit>();
        var satirlar = File.ReadAllLines(dosyaYolu);
        foreach (var satir in satirlar)
        {
            var parcalar = satir.Split(" ");
            var temizlenmisParcalar = parcalar.Where(x => x != "").ToList();
            var kayit = new DepremKayit(temizlenmisParcalar);
            liste.Add(kayit);
        }
    }
}