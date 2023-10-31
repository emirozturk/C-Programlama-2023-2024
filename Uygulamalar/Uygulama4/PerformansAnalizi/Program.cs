using System.Text;

class Sayi
{
    private string sayi;

    public Sayi(string sayi)
    {
        this.sayi = sayi;
    }

    public int Hesapla()
    {
        return 0;
    }
}
class main
{
    public static void Main(string[] args)
    {
        /*
        String a = "";
        for (int i = 0; i < 300_000; i++)
        {
            a += "a";
        }
        */
        StringBuilder a = new StringBuilder();
        for (int i = 0; i < 1_000_000_000; i++)
        {
            a.Append("a");
        }
        a.ToString();
    }
}