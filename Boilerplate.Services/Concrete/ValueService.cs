using Boilerplate.Services.Abstract;
using Boilerplate.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Boilerplate.Domain.Db;
using Boilerplate.Services.Models.GetValue;

namespace Boilerplate.Services.Concrete
{
    public class ValueService : AppService, IValueService
    {
        public ValueService(BoilerplateDbContext db) : base(db)
        {
        }
        public IResponse<GetValueResponse> Get(GetValueRequest request)
        {
            if (request.Id == 0)
            {
                return Fail<GetValueResponse>("Error");
            }
            return Ok(new GetValueResponse() { Value = request.Id.ToString() });
        }
    }
}
