using Boilerplate.Services.Extensions;
using Boilerplate.Services.Models.GetValue;

namespace Boilerplate.Services.Abstract
{
    public interface IValueService
    {
        IResponse<GetValueResponse> Get(GetValueRequest request);
    }
}
