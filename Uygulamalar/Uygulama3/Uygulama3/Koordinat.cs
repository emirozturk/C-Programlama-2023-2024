namespace Uygulama3;

public class Koordinat
{
    double Enlem { get; set; }
    double Boylam { get; set; }
    double Derinlik { get; set; }    
    string Yer { get; set; }
    
    public Koordinat(string[] parcalar, string[] yerParcalari)
    {
        Enlem = Convert.ToDouble(parcalar[0].Replace(".",","));
        Boylam = Convert.ToDouble(parcalar[1].Replace(".",","));
        Derinlik = Convert.ToDouble(parcalar[2].Replace(".",","));
        Yer = String.Join(" ", yerParcalari);
    }
    
}