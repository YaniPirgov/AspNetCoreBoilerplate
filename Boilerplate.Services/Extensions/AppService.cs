using Boilerplate.Domain.Db;

namespace Boilerplate.Services.Extensions
{
    public class AppService
    {
        protected readonly BoilerplateDbContext Db;
        public AppService(BoilerplateDbContext db)
        {
            Db = db;
        }
        protected IResponse<TResponse> Fail<TResponse>(params string[] errorMessages)
        {
            var result = new AppServiceResponse<TResponse>();
            result.Success = false;
            if (errorMessages != null)
            {
                result.Errors = errorMessages;
            }

            return result;
        }
        protected IResponse<TResponse> Ok<TResponse>(TResponse data)
        {
            var result = new AppServiceResponse<TResponse>();
            result.Data = data;
            result.Success = true;
            return result;
        }
    }
}
