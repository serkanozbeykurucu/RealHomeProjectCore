using AutoMapper;
using RealHomeProject.Dto.Dtos.BlogDTOs;
using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.WebUI.Mapping.AutoMapperProfile
{
	public class MapProfile : Profile
	{
		public MapProfile()
		{
			CreateMap<Blog, BlogListDto>().IncludeAllDerived();
            CreateMap<BlogListDto, Blog>().IncludeAllDerived();

        }
    }
}
