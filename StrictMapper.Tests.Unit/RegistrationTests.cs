namespace StrictMapper.Tests.Unit;

public class RegistrationTests
{
    [SetUp]
    public void Setup()
    {
        Initializer.Initialize(GetType().Assembly);
    }

    [Test]
    public void ShouldNotThrowAfterRegister()
    {
        Assert.Pass();
    }
}