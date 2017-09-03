using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Boilerplate.Services.Models.GetValue;
using Boilerplate.Services.Extensions;
using Boilerplate.Services.Abstract;
using Boilerplate.Services.Concrete;

namespace Boilerplate.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IValueService _valueService;
        public ValuesController(IValueService valueService)
        {
            _valueService = valueService;
        }
        [HttpGet]
        public IResponse<GetValueResponse> Get([FromQuery]GetValueRequest request)
        {
            return _valueService.Get(request);
        }
    }
}
