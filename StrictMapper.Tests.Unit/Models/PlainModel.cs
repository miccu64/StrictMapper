namespace StrictMapper.Tests.Unit.Models;

public class PlainModel
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required CoordinatesStruct Coordinates { get; set; }
    public DateTime? DateOfBirth { get; set; }
}