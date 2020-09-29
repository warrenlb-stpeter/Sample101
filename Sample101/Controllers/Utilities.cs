using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample101.Controllers
{
    public class Utilities
    {
    }


    public class NoDirectAccessAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var canAccess = false;

            //check the refer
            var referer = context.HttpContext.Request.Headers["Referer"].ToString();
            if (!string.IsNullOrEmpty(referer))
            {
                var request = context.HttpContext.Request;
                var rUri = new System.UriBuilder(referer).Uri;
                if (request.Host.Host == rUri.Host && request.Host.Port == rUri.Port && request.Scheme == rUri.Scheme)
                {
                    canAccess = true;
                }
            }

            // ... check other requirements

            if (!canAccess)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Index", area = "" }));
            }
        }
    }
}
