using BusinessLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ObjectiveController : ControllerBase
	{
		private readonly IObjectiveService _objectiveService = null;

		public ObjectiveController(IObjectiveService objectiveService)
		{
			this._objectiveService = objectiveService;
		}

		[HttpGet]
		[Route("GetObjectives")]
		public IActionResult GetObjectives()
		{
			var data = _objectiveService.GetObjectives();
			return Ok(data);
		}
	}
}
