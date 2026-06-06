using StrictMapper.Interfaces;
using StrictMapper.Tests.Unit.Models;

namespace StrictMapper.Tests.Unit.Mappers;

public class CoordinatesStructToCoordinatesClassMapper : IMapper<CoordinatesStruct, CoordinatesClass>
{
    public CoordinatesClass Map(CoordinatesStruct source)
    {
        return new CoordinatesClass
        {
            X = source.X,
            Y = source.Y
        };
    }
}