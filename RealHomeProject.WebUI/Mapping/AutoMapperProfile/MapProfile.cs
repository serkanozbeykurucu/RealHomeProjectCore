using AutoMapper;
using RealHomeProject.Dto.Dtos.BlogDTOs;
using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.WebUI.Mapping.AutoMapperProfile
{
	public class MapProfile : Profile
	{
		public MapProfile()
		{
			CreateMap<BlogListDto, Blog>().IncludeAllDerived();
			CreateMap<Blog, BlogListDto>().IncludeAllDerived();
        }
	}
}
