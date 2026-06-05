namespace StrictMapper.Models;

public record MapperType : IEqualityComparer<MapperType>
{
    public MapperType(Type inType, Type outType)
    {
        InType = inType;
        OutType = outType;
    }

    public Type InType { get; }
    public Type OutType { get; }

    public bool Equals(MapperType? x, MapperType? y)
    {
        if (ReferenceEquals(x, y))
            return true;
        if (x is null) 
            return false;
        if (y is null) 
            return false;
        if (x.GetType() != y.GetType()) 
            return false;
        return x.InType == y.InType && x.OutType == y.OutType;
    }

    public int GetHashCode(MapperType obj)
    {
        return HashCode.Combine(obj.InType, obj.OutType);
    }
}