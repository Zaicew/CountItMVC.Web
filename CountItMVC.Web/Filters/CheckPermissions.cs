using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CountItMVC.Web.Filters
{
    public class CheckPermissions : Attribute, IAuthorizationFilter
    {
        private readonly string _permission;
        public CheckPermissions(string permission)
        {
            _permission = permission;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool isAuthorized = CheckPermission(context.HttpContext.User, _permission);
            //context.HttpContext.User.Claims();
            if(!isAuthorized)
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool CheckPermission(ClaimsPrincipal user, string permission)
        {
            // join z datbase
            //download user
            //check if this user have access to this action

            return permission == "Read";
        }
    }
}
