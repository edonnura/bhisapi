using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BHISApi.Custom.Models.Login
{
    public class Credentials
    {
        //[Required(ErrorMessage = "Password field is required!")]
        public string Username { get; set; }

        //[Required(ErrorMessage ="Password field is required!")]
        //[MinLength(6, ErrorMessage ="Minimum length of password is 6 character long.")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
