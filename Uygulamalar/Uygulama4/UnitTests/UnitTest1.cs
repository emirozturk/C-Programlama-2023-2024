using Uygulama4;

namespace UnitTests;

public class Tests
{
    private Login login;
    [SetUp]
    public void Setup()
    {
        login = new Login();
    }

    [Test]
    public void BosIsimTesti()
    {
        Kisi k = new Kisi(null, "Öztürk", "123", 56);
        var sonuc = login.CheckLogin(k);
        Assert.That(sonuc, Is.EqualTo(0));
    }
    [Test]
    public void BosSoyisimTesti()
    {
        Kisi k = new Kisi("Emir", null, "123", 56);
        var sonuc = login.CheckLogin(k);
        Assert.That(sonuc, Is.EqualTo(0));
    }
    [Test]
    public void BosSifreTesti()
    {
        Kisi k = new Kisi("Emir", "Öztürk", null, 56);
        var sonuc = login.CheckLogin(k);
        Assert.That(sonuc, Is.EqualTo(0));
    }
    [Test]
    public void YanlisSifreTesti()
    {
        Kisi k = new Kisi("Emir", "Öztürk", "456", 56);
        var sonuc = login.CheckLogin(k);
        Assert.That(sonuc, Is.EqualTo(0));
    }
    [Test]
    public void DogruSifreTesti()
    {
        Kisi k = new Kisi("Emir", "Öztürk", "123", 56);
        var sonuc = login.CheckLogin(k);
        Assert.That(sonuc, Is.EqualTo(1));
    }
    [Test]
    public void YasTesti()
    {
        Kisi k1 = new Kisi("Emir", "Öztürk", "123", 54);
        Kisi k2 = new Kisi("İshak", "Doğanay", "38", 16);
        Kisi k3 = new Kisi("Serdest", "Onat", "72", 18);
        Kisi k4 = new Kisi("Abdullah", "Vural", "81", 20);
        Assert.That(login.CheckLogin(k1), Is.EqualTo(1));
        Assert.That(login.CheckLogin(k2), Is.EqualTo(0));
        Assert.That(login.CheckLogin(k3), Is.EqualTo(1));
        Assert.That(login.CheckLogin(k4), Is.EqualTo(1));
    }
}