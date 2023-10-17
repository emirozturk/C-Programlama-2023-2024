namespace Uygulama3;

class main
{
    public static void Main(string[] args)
    {
        var dosyaYolu =
            "/Users/emirozturk/Desktop/GitHub/C-Programlama-2023-2024/Uygulamalar/Uygulama3/Uygulama3/depremVeri.txt";
        //FileStream depremDosya = new FileStream(dosyaYolu, FileMode.Open);
        //var brDepremVeri = new BinaryReader(depremDosya);
        //var sonuc = brDepremVeri.ReadInt32();
        //Console.WriteLine(sonuc);
        //StreamReader srDepremVeri = new StreamReader(depremDosya);
        //Console.WriteLine(srDepremVeri.Read());
        var depremKayitListesi = new DepremKayitListesi(dosyaYolu);
    }
}