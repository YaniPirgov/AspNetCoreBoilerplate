using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Services.Models.GetValue
{
    public class GetValueRequest
    {
        public int Id { get; set; }
    }
    public class GetValueResponse
    {
        public string Value { get; set; }
    }
}
