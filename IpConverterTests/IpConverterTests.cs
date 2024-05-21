using IpConverter;

namespace IpConverterTests;

public class Tests
{
    [Test]
    public void TestIPtoInt_ValidIP()
    {
        Assert.That(IpConvert.ToInt32("128.32.10.1"), Is.EqualTo(2149583361), "Incorrect answer for ip = \"128.32.10.1\"");
    }

    [Test]
    public void TestIPtoInt_AllZeros()
    {
        Assert.That(IpConvert.ToInt32("0.0.0.0"), Is.EqualTo(0), "Incorrect answer for ip = \"0.0.0.0\"");
    }

    [Test]
    public void TestIPtoInt_AllOnes()
    {
        Assert.That(IpConvert.ToInt32("255.255.255.255"), Is.EqualTo(4294967295), "Incorrect answer for ip = \"255.255.255.255\"");
    }

    [Test]
    public void TestIPtoInt_LeadingZeros()
    {
        Assert.That(IpConvert.ToInt32("001.002.003.004"), Is.EqualTo(16909060), "Incorrect answer for ip = \"001.002.003.004\"");
    }

    [Test]
    public void TestIPtoInt_RandomIP()
    {
        Assert.That(IpConvert.ToInt32("192.168.0.1"), Is.EqualTo(3232235521), "Incorrect answer for ip = \"192.168.0.1\"");
    }

    [Test]
    public void TestIPtoInt_RandomIP2()
    {
        Assert.That(IpConvert.ToInt32("10.0.0.1"), Is.EqualTo(167772161), "Incorrect answer for ip = \"10.0.0.1\"");
    }
}