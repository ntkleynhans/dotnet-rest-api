using AutoMapper;
namespace dotnet_webapi.Services.BasicService;

public class BasicService : IBasicService
{
    private readonly IMapper _mapper;
    public BasicService(IMapper mapper)
    {
        _mapper = mapper;
    }
    public async Task<ServiceResponse<GetBasicDto>> GetBasic()
    {
        var sR = new ServiceResponse<GetBasicDto>();
        var basic =  new Basic();
        sR.Data = _mapper.Map<GetBasicDto>(basic);
        return sR;
    }
}
