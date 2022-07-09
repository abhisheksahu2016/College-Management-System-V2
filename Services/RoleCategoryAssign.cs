using System;
using System.Collections.Generic;

using CMS.Constants;
using Microsoft.AspNetCore.Authorization;

namespace CMS.Services
{
    public  class AuthorizeByRoleAttribute : AuthorizeAttribute
    {
        public void SetAuthorizeAttribute(string[] roles)
        {
            Roles = String.Join(",", roles);
        }
    }
}
