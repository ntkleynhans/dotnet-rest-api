namespace dotnet_webapi.Services.BasicService;

public interface IBasicService
{
    public Task<ServiceResponse<GetBasicDto>> GetBasic();
}
