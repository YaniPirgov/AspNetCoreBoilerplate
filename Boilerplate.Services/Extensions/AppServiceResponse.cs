using System.Collections.Generic;

namespace Boilerplate.Services.Extensions
{
    public class AppServiceResponse<TResponse> : IResponse<TResponse>
    {
        public TResponse Data { get; set; }

        public IEnumerable<string> Errors { get; set; }

        public bool Success { get; set; }
    }
}
