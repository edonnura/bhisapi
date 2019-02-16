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
    public class HistoryController : Controller
    {
        [Authorize]
        [Route("api/History/Get")]
        public async Task<IActionResult> Get(int Id)
        {
            if (Id > 0)
            {
                var result = (await new HistoryRepository().GetPatientCases(Id));
                if (result.HasError)
                    return StatusCode((int)HttpStatusCode.InternalServerError);
                return Ok(result.Result);
            }
            else return BadRequest();
        }

        [Authorize]
        [Route("api/History/Origin")]
        public async Task<IActionResult> Origin(int IdVisit)
        {
            if (IdVisit > 0)
            {
                var result = (await new HistoryRepository().GetVisitOrigin(IdVisit));
                if (result.HasError)
                    return StatusCode((int)HttpStatusCode.InternalServerError);
                return Ok(result.Result);
            }
            else return BadRequest();
        }

        [Authorize]
        [Route("api/History/Examination")]
        public async Task<IActionResult> Examination(int IdVisit)
        {
            if (IdVisit > 0)
            {
                var result = (await new HistoryRepository().GetVisitExamination(IdVisit));
                if (result.HasError)
                    return StatusCode((int)HttpStatusCode.InternalServerError);
                return Ok(result.Result);
            }
            else return BadRequest();
        }

        [Authorize]
        [Route("api/History/Diagnose")]
        public async Task<IActionResult> Diagnose(int IdVisit)
        {
            if (IdVisit > 0)
            {
                var result = (await new HistoryRepository().GetVisitDiagnose(IdVisit));
                if (result.HasError)
                    return StatusCode((int)HttpStatusCode.InternalServerError);
                return Ok(result.Result);
            }
            else return BadRequest();
        }

        [Authorize]
        [Route("api/History/Therapy")]
        public async Task<IActionResult> Therapy(int IdVisit)
        {
            if (IdVisit > 0)
            {
                var result = (await new HistoryRepository().GetVisitTherapy(IdVisit));
                if (result.HasError)
                    return StatusCode((int)HttpStatusCode.InternalServerError);
                return Ok(result.Result);
            }
            else return BadRequest();
        }

        [Authorize]
        [Route("api/History/Conclusion")]
        public async Task<IActionResult> Conclusion(int IdVisit)
        {
            if (IdVisit > 0)
            {
                var result = (await new HistoryRepository().GetVisitConclusion(IdVisit));
                if (result.HasError)
                    return StatusCode((int)HttpStatusCode.InternalServerError);
                return Ok(result.Result);
            }
            else return BadRequest();
        }

        [Authorize]
        [Route("api/History/Services")]
        public async Task<IActionResult> Services(int IdVisit)
        {
            if (IdVisit > 0)
            {
                var result = (await new HistoryRepository().GetVisitServices(IdVisit));
                if (result.HasError)
                    return StatusCode((int)HttpStatusCode.InternalServerError);
                return Ok(result.Result);
            }
            else return BadRequest();
        }

        [Authorize]
        [Route("api/History/PaymentCode")]
        public async Task<IActionResult> PaymentCode(int IdVisit)
        {
            if (IdVisit > 0)
            {
                var result = (await new HistoryRepository().GetVisitPaymentCode(IdVisit));
                if (result.HasError)
                    return StatusCode((int)HttpStatusCode.InternalServerError);
                return Ok(result.Result);
            }
            else return BadRequest();
        }

        [Authorize]
        [Route("api/History/Referral")]
        public async Task<IActionResult> Referal(int IdVisit)
        {
            if (IdVisit > 0)
            {
                var result = (await new HistoryRepository().GetReferral(IdVisit));
                if (result.HasError)
                    return StatusCode((int)HttpStatusCode.InternalServerError);
                return Ok(result.Result);
            }
            else return BadRequest();
        }
    }
}