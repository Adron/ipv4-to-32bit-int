using IpConverter;

namespace IpConverterTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestIPtoInt()
    {
        Assert.That(IpConvert.ToInt32("128.32.10.1"), Is.EqualTo(2149583361), "Incorrect answer for ip = \"128.32.10.1\"");
    }
}