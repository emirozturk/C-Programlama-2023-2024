using System.Security;

namespace Uygulama2;

class Sinif
{
    public int Veri { get; }

    public Sinif(int Veri)
    {
        this.Veri = Veri;
    }
}

class DoubleSinif
{
    public double Veri { get; }

    public DoubleSinif(double Veri)
    {
        this.Veri = Veri;
    }
}

class GenelSinif<T>
{
    public T Veri { get; }

    public GenelSinif(T Veri)
    {
        this.Veri = Veri;
    }
}
class main
{
    /*
    public static void Main(string[] args)
    {
        var nesne = new Sinif(5);
        Console.WriteLine(nesne.Veri);
        var nesne2 = new DoubleSinif(3.15);
        var genelNesne = new GenelSinif<int>(5);
        var genelNesne2 = new GenelSinif<double>(5.3);
    }
    */
}
