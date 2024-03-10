using AutoMapper;
using ShoppingWebApp.Services.CouponAPI.Models;
using ShoppingWebApp.Services.CouponAPI.Models.Dto;

namespace ShoppingWebApp.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon,CouponDto>();
            });
            return mappingConfig;
        }

    }
}
