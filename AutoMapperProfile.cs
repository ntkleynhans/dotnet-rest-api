using AutoMapper;

class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Basic, GetBasicDto>();
    }    
}
