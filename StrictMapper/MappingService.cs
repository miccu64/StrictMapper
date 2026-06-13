using StrictMapper.Exceptions;
using StrictMapper.Interfaces;
using StrictMapper.Models;

namespace StrictMapper;

public static class MappingService // : IMappingService
{
    // TODO: move away from static
    public static TDest Map<TSource, TDest>(TSource source)
    {
        MapperType mapperType = new(typeof(TSource), typeof(TDest));
        if (!Initializer.mappings.TryGetValue(mapperType, out object mapperObj))
            throw new MissingMapperException(mapperType);

        return ((IMapper<TSource, TDest>)mapperObj).Map(source);
    }
}