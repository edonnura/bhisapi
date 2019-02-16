using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using BHISApi.Custom.Models.Login;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BHISApi.Custom.DatabaseRepository;
using Microsoft.AspNetCore.Http;

namespace BHISApi.Controllers
{
    [ApiController]
    public class LoginController : Controller
    {
        [Route("api/Login/Token")]
        [HttpPost]
        public async Task<IActionResult> Token([FromBody] Credentials credentials)
        {
            if (ModelState.IsValid)
            {
                var result = await new LoginRepository().CheckPersonalNumber(credentials.Username);
                if (!result.HasError)
                {
                    if (result.Result > 0)
                    {
                        var claimData = new[] { new Claim(ClaimTypes.Name, credentials.Username) };
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("123321123321123321"));
                        var signInCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                        var token = new JwtSecurityToken
                            (
                             claims: claimData,
                             signingCredentials: signInCredentials
                            );
                        return Ok(new TokenResult { Id = result.Result, Token = new JwtSecurityTokenHandler().WriteToken(token) });
                        //return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                    }
                    else return BadRequest();
                }
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return BadRequest();
        }
    }
}