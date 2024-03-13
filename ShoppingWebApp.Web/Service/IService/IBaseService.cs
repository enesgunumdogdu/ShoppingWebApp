using ShoppingWebApp.Web.Models;

namespace ShoppingWebApp.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
