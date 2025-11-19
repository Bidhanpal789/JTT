using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTT.Models
{
    public class LoginModel
    {
        public string email { get; set; }
        public string password { get; set; }
        
        List<UserDetailsModel>userDetails=new List<UserDetailsModel>(); 
    }
}