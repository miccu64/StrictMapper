using StrictMapper.Interfaces;

namespace StrictMapper;

public static class Initializer
{
    private static List<IMapper> mappings = new();
    
    public static void Initialize(Type type)
    {
        List<Type> mappers = type.Assembly.GetTypes()
            .Where(x => !x.IsAbstract && x.IsClass && x.GetInterface(nameof(IMapper<,>)) == typeof(IMapper<,>)).ToList();

        foreach (Type mapper in mappers)
        {
            services.Add(new ServiceDescriptor(typeof(IRule), rule, ServiceLifetime.Transient));
        }
    }
}