namespace Uygulama8;

public class Kisi
{
    public string AdSoyad {get; set; }
    public int Boy {get; set; }

    public override string ToString()
    {
        return $"{AdSoyad}-{Boy}";
    }
}