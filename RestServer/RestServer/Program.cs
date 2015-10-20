using System;
using Microsoft.Owin.Hosting;

namespace RestServer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string baseAddress = "http://localhost:5000";

			using (WebApp.Start<Startup> (baseAddress)) {
				Console.WriteLine ("Start server");
				Console.ReadLine ();
			}
		}
	}
}
