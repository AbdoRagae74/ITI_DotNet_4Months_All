using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WEBAPIDay01.DTOs.AccountDTO;

namespace WEBAPIDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public IActionResult login(loginDTO data) { 
        

            if(data.userName=="a" && data.Password == "123")
            {
                #region Generate claims

                //Claims => data about user

                List<Claim> userData = new List<Claim>();
                userData.Add(new Claim("Username", data.userName));
                userData.Add(new Claim("role", "Admin"));
                userData.Add(new Claim(ClaimTypes.MobilePhone, "01026401435"));

                #endregion

                #region Secret key + sigingCred
                string key = "abcdfgvbghnmjkflabcdfgvbghnmjkfl";
                var secretKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key));
                var signingcred = new SigningCredentials(secretKey,SecurityAlgorithms.HmacSha256);
                #endregion
                //Generate token 
                //Token
                //=> Header type , hash algo ,
                //   payload Claims , expire date,
                //   signature => Secret key "hashing"
                JwtSecurityToken tokenobject = new JwtSecurityToken(

                #region Payload
                    claims: userData,
                    expires: DateTime.Now.AddDays(1) ,
                #endregion
                    signingCredentials:signingcred
                    );
                //var tokenobjectx = new JwtSecurityToken();    

                //Convert token to string
                string finalToken = new JwtSecurityTokenHandler().WriteToken(tokenobject);   

                return Ok(finalToken);
            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpGet]
        //[Authorize]
        public IActionResult getAll()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }
            else
                return Ok();
        }
    }
}
