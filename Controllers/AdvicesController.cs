using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BHISApi.Custom.DatabaseRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHISApi.Controllers
{
    [ApiController]
    public class AdvicesController : Controller
    {
        [Authorize]
        [Route("api/Advices/Get")]
        public async Task<IActionResult> Get()
        {
            var result = (await new AdvicesRepository().GetAdvices());
            if (result.HasError)
                return StatusCode((int)HttpStatusCode.InternalServerError);
            return Ok(result.Result);
        }
    }
}