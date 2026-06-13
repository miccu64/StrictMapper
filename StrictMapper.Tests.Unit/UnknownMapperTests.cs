using StrictMapper.Exceptions;
using StrictMapper.Tests.Unit.Models;

namespace StrictMapper.Tests.Unit;

public class UnknownMapperTests
{
    [SetUp]
    public void Setup()
    {
        Initializer.Initialize(GetType().Assembly);
    }

    [Test]
    public void ShouldThrowOnUnknownMapper()
    {
        // Arrange
        MyClass source = new();

        // Act / Assert
        Assert.Throws<MissingMapperException>(() => MappingService.Map<MyClass, CoordinatesClass>(source));
    }

    [Test]
    public void ShouldGiveDetailsOfUnknownMapper()
    {
        // Arrange
        MyClass source = new();
        string errorMessage = "";

        // Act
        try
        {
            MappingService.Map<MyClass, CoordinatesClass>(source);
        }
        catch (MissingMapperException ex)
        {
            errorMessage = ex.Message;
        }

        // Assert
        Assert.That(errorMessage, Contains.Substring($"<{typeof(MyClass)}, {typeof(CoordinatesClass)}>"));
    }

    private class MyClass
    {
        public int Id { get; set; }
    }
}