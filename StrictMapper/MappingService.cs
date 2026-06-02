using StrictMapper.Interfaces;

namespace StrictMapper;

public class MappingService : IMappingService
{
    public TDest Map<TSource, TDest>(TSource source)
    {
        throw new NotImplementedException();
    }
}