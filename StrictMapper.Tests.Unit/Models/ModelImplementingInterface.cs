namespace StrictMapper.Tests.Unit.Models;

public class ModelImplementingInterface : ISomeInterface
{
    public required int Id { get; init; }
    public int Year { get; init; }
    public required CoordinatesStruct Coordinates { get; init; }
}