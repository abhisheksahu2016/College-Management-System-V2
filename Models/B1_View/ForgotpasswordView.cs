using System;
using System.Collections.Generic;

using CMS.Models.A1_DB;

namespace CMS.Models.B1_View
{
    public class ForgotpasswordView
    {
        public string UserId { get; set; }
        public string PetName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
