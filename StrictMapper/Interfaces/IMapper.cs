namespace StrictMapper.Interfaces;

public interface IMapper<in TSource, out TDest>
    where TSource : class
    where TDest : class
{
    TDest Map(TSource source);
}