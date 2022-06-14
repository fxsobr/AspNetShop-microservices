using AspNetShop.ProductAPI.Data.ValueObjects;
using AspNetShop.ProductAPI.Model;
using AutoMapper;

namespace AspNetShop.ProductAPI.Config;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig =  new MapperConfiguration(config =>
        {
            config.CreateMap<ProductVO, Product>();
            config.CreateMap<Product, ProductVO>();
        });
        return mappingConfig;
    }
}