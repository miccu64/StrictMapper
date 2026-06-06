using StrictMapper.Interfaces;
using StrictMapper.Tests.Unit.Models;

namespace StrictMapper.Tests.Unit.Mappers;

public class ModelImplementingInterfaceToPlainModelMapper : IMapper<ModelImplementingInterface, PlainModel>
{
    public PlainModel Map(ModelImplementingInterface source)
    {
        return new PlainModel
        {
            Id = source.Id,
            Coordinates = source.Coordinates,
            Name = string.Empty,
            DateOfBirth = new DateTime(source.Year)
        };
    }
}