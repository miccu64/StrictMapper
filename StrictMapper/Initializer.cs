using System.Reflection;
using StrictMapper.Interfaces;
using StrictMapper.Models;

namespace StrictMapper;

public static class Initializer
{
    public static readonly Dictionary<MapperType, object> mappings = new();

    public static void Initialize(Assembly assembly)
    {
        const string mapperName = nameof(IMapper<,>);
        Type mapperType = typeof(IMapper<,>);
        
        List<Type> mappers = assembly.GetTypes()
            .Where(x => !x.IsAbstract && x.IsClass && x.GetInterface(mapperName) == mapperType)
            .ToList();

        foreach (Type mapper in mappers)
        {
            Type[] genericArguments = mapper.GetGenericArguments();
            MapperType mapperTypeKey = new(genericArguments[0], genericArguments[1]);
            mappings.TryAdd(mapperTypeKey, mapper);
        }
    }
}