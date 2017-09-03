using System.Collections.Generic;

namespace Boilerplate.Services.Extensions
{
    public interface IResponse<TResponse>
    {
        bool Success { get; set; }

        IEnumerable<string> Errors { get; set; }

        TResponse Data { get; set; }
    }
}
