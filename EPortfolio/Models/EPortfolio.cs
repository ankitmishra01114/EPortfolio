using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace EPortfolio.Models
{
    public class Credentials
    {
        public int? userid { get; set; }
        public string profileid { get; set; }
    }
    public class RegisterUser:Credentials
    {
        public string email { get; set; }
        public int? phoneno { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }

    }
}