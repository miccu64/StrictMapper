using StrictMapper.Models;

namespace StrictMapper.Exceptions;

public class MissingMapperException(MapperType mapperType)
    : InvalidOperationException($"No implementation of {mapperType}");