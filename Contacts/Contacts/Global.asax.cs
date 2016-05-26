using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls; 
using System.Web.Security;
using System.Web.SessionState;

namespace Contacts
{
	public class Global : System.Web.HttpApplication
	{

		protected void Application_Start(object sender, EventArgs e)
		{
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.EnableFriendlyUrls();

			// Put any additional route registrations here.
		}

		protected void Session_Start(object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}