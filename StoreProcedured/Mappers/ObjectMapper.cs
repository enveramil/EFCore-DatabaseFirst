using AutoMapper;
using StoreProcedured.DataAccessLayer;
using StoreProcedured.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProcedured.Mappers
{
    internal class ObjectMapper
    {

        private static readonly Lazy<IMapper> _mapper = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CustomMapping>();
            });

            return config.CreateMapper();
        });

        public static IMapper Mapper => _mapper.Value;

    }


    internal class CustomMapping : Profile
    {
        public CustomMapping()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
        }
    }
}
