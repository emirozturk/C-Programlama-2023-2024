namespace Uygulama3;

public class Buyukluk
{
    double MD { get; set; }
    double ML { get; set; }
    double Mw { get; set; }

    private string Donustur(string deger)
    {
        return deger == "-.-" ? "-1" : deger;
    }
    public Buyukluk(string[] parcalar)
    {
        var degisenParcalar = parcalar.Select(Donustur).ToArray();
        MD = Convert.ToDouble(degisenParcalar[0].Replace(".",","));
        ML = Convert.ToDouble(degisenParcalar[1].Replace(".",","));
        Mw = Convert.ToDouble(degisenParcalar[2].Replace(".",","));
    }

}