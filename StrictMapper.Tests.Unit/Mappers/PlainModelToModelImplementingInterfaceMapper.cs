using StrictMapper.Interfaces;
using StrictMapper.Tests.Unit.Models;

namespace StrictMapper.Tests.Unit.Mappers;

public class PlainModelToModelImplementingInterfaceMapper : IMapper<PlainModel, ModelImplementingInterface>
{
    public ModelImplementingInterface Map(PlainModel source)
    {
        return new ModelImplementingInterface
        {
            Id = source.Id,
            Coordinates = source.Coordinates,
            Year = DateTimeOffset.Now.Year
        };
    }
}