using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTT.Models
{
    public class UserDetailsModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? DOB { get; set; }
        public string Email { get; set; }
        public string IdType { get; set; }
    }
}