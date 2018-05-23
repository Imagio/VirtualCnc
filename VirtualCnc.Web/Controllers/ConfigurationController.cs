using Microsoft.AspNetCore.Mvc;
using VirtualCnc.Contracts;

namespace VirtualCnc.Web
{
	[Route("api/[controller]")]
	public class ConfigurationController : Controller
	{
		[HttpGet("getConfiguration")]
		[ProducesResponseType(typeof(CncConfigurationModel), 201)]
		[ProducesResponseType(400)]
		public IActionResult GetConfiguration()
		{
			return new ObjectResult(new CncConfigurationModel()); 
		}
	}
}