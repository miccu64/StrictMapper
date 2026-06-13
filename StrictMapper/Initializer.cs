using System.Reflection;
using StrictMapper.Interfaces;
using StrictMapper.Models;

namespace StrictMapper;

public static class Initializer
{
    public static readonly Dictionary<MapperType, object> mappings = new();

    public static void Initialize(Assembly assembly)
    {
        var mappers = assembly.GetTypes()
            .Where(t => !t.IsAbstract && !t.IsInterface)
            .Select(t => new
            {
                Type = t,
                Interface = t.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapper<,>))
            })
            .Where(x => x.Interface != null)
            .ToList();

        foreach (var mapper in mappers)
        {
            Type[] genericArguments = mapper.Interface!.GetGenericArguments();
            MapperType mapperTypeKey = new(genericArguments[0], genericArguments[1]);

            // TODO: duplicate checks
            mappings.TryAdd(mapperTypeKey, mapper);
        }
    }
}