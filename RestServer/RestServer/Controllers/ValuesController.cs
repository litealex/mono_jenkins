using System;
using System.Web.Http;
using System.Threading.Tasks;

namespace RestServer
{
	public class ValuesController:ApiController
	{
		public async Task<object> Get(){
			return await Task.FromResult (new[]{ "value1", "value2" });
		}
	}
}

