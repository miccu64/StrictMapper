using StrictMapper.Tests.Unit.Models;

namespace StrictMapper.Tests.Unit;

public class MappingTests
{
    [SetUp]
    public void Setup()
    {
        Initializer.Initialize(GetType().Assembly);
    }

    [Test]
    public void T()
    {
        // Arrange
        CoordinatesStruct s = new()
        {
            X = 1,
            Y = 2
        };

        // Act
        CoordinatesClass c = MappingService.Map<CoordinatesStruct, CoordinatesClass>(s);

        // Assert
        Assert.That(c, Is.Not.Null);
        using (Assert.EnterMultipleScope())
        {
            Assert.That(c.X, Is.EqualTo(s.X));
            Assert.That(c.Y, Is.EqualTo(s.Y));
            Assert.That(c.Z, Is.Null);
        }
    }
}