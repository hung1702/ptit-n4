using System;
using System.Collections.Generic;
using System.Text;

namespace QLDTMobile.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
