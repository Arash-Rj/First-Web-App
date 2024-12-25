using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication1.Appsrc.DataBase
{

	public class CustomAuthorizeAttribute : Attribute, IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationFilterContext context)
		{
			// Access HttpContext directly
			var httpContext = context.HttpContext;

			// Check if user is authenticated
			if (OnlineUser.Onlineuser is null)
			{
				context.Result = new UnauthorizedResult(); // Return 401 Unauthorized
				return;
			}

			// Custom logic: Check the logged-in user
			var loggedInUser = httpContext.User.Identity.Name; 
			if (loggedInUser != OnlineUser.Onlineuser.Name) // "OnlineUser" is your static class/field
			{
				context.Result = new ForbidResult(); // Return 403 Forbidden
			}
		}
	}


}
