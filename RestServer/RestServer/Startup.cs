using System;
using Owin;
using System.Web.Http;

namespace RestServer
{
	public class Startup
	{
		public void Configuration(IAppBuilder app){
			var config = new HttpConfiguration ();
			config.Routes.MapHttpRoute ("Default", "api/{controller}/{id}", new {id = RouteParameter.Optional});
			app.UseWebApi (config);
		}
	}
}

