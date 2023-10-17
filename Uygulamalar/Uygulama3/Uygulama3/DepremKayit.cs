using System.Security;

namespace Uygulama3;

public class DepremKayit
{
    DateTime TarihSaat { get; set; }
    Koordinat Koordinat { get; set; }
    Buyukluk Buyukluk { get; set; }
    string CozumNiteligi { get; set; }

    public DepremKayit(List<string> parcalarl)
    {
        var parcalar = parcalarl.ToArray();
        TarihSaat = DateTime.ParseExact($"{parcalar[0]}-{parcalar[1]}", "yyyy.MM.dd-HH:mm:ss", null);
        Koordinat = new Koordinat(parcalar[2..5],parcalar[8..^1]);
        Buyukluk = new Buyukluk(parcalar[5..8]);
        CozumNiteligi = parcalar[^1];
    }
}