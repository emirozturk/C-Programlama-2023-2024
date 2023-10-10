using System.Text.RegularExpressions;

namespace Uygulama2;

public class SonSaat
{
    static string RemovePunctuation(string text)
    {
        return Regex.Replace(text, @"[!""#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~\s]", "");
    }
    public static void Main(string[] args)
    {
        Dictionary<string, int> kelimeler = new Dictionary<string, int>();
        string cumle = "2-1 öndeyiz. seni 14'te durduran şey neydi. hem penaltı hem gol. " +
                       "bir berber bir berbere gel beraber bir berber dükkanı açalım demiş";
        var parcalar = cumle.Split(" ");
        var temizlenmisParcalar = parcalar
            .Select(RemovePunctuation)
            .ToList();
        foreach (var parca in temizlenmisParcalar)
            if (kelimeler.ContainsKey(parca))
                kelimeler[parca]++;
            else
                kelimeler.Add(parca,1);
        foreach(var anahtar in kelimeler.Keys)
            Console.WriteLine($"{anahtar}:{kelimeler[anahtar]}");
    }
}