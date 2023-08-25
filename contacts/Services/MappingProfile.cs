using AutoMapper;
using Contacts.Models;
using Contacts.ViewModels.Contacts;

public static class MappingConfig
{
    public static IMapper RegisterMappings()
    {
        var config = new MapperConfiguration(cfg =>
        {});

        return config.CreateMapper();
    }
}
