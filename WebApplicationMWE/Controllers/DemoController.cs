using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Types;

namespace WebApplicationMWE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("nullable-int")]
        public ActionResult<int?> GetNullableInt()
        {
            return Ok();
        }

        [HttpGet("nullable-struct")]
        public ActionResult<RetType?> GetNullableStruct()
        {            
            return Ok();
        }        
    }    
}
