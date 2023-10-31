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
        Assert.That(sonuc, Is.EqualTo(1));
    }
    [Test]
    public void BosSoyisimTesti()
    {
        Kisi k = new Kisi("Emir", null, "123", 56);
        var sonuc = login.CheckLogin(k);
        Assert.That(sonuc, Is.EqualTo(1));
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
}