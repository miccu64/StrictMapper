using System.Reflection;
using StrictMapper.Interfaces;
using StrictMapper.Models;

namespace StrictMapper;

public static class Initializer
{
    public static readonly Dictionary<MapperType, IMapper<dynamic, dynamic>> mappings = new();

    public static void Initialize(Assembly assembly)
    {
        List<Type> mappers = assembly.GetTypes()
            .Where(x => !x.IsAbstract && x.IsClass && x.GetInterface(nameof(IMapper<,>)) == typeof(IMapper<,>))
            .ToList();

        foreach (Type mapper in mappers)
        {
            MapperType mapperType = new MapperType(mapper.GetGenericArguments()[0], mapper.GetGenericArguments()[1]);
            mappings.TryAdd(mapperType, (IMapper<dynamic, dynamic>)mapper);
        }
    }
}