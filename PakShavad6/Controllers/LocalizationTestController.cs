using LocalizationTest.Resources.Common;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace PakShavad6.Controllers;


[Route("api/[controller]")]
[ApiController]
public class LocalizationTestController : ControllerBase
{
	private readonly IStringLocalizer<Errors> _localizer;

	public LocalizationTestController(IStringLocalizer<Errors> localizer)
	{
		_localizer = localizer;
	}

	[HttpGet("errors")]
	public IActionResult GetErrors()
	{
		var localizedString = _localizer["Hello"];
		return Ok(localizedString);
	}
}