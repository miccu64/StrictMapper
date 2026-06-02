namespace StrictMapper.Interfaces;

public interface IMappingService
{
    TDest Map<TSource, TDest>(TSource source);
}