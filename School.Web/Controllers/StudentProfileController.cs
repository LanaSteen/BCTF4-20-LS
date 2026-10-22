using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Application.Services.Interfaces;

namespace School.Web.Controllers
{
	//[Authorize]
	[Route("api/studetns/{studentid:int}/profile")]
	[ApiController]
	public class StudentProfileController : ControllerBase
	{

		private readonly IStudentProfileService _studentService;

		public StudentProfileController(IStudentProfileService studentService)
		{
			_studentService = studentService;
		}


		[HttpPost]
		[Consumes("multipart/form-data")]

		//public async Task<IActionResult> UploadProfilePicture(int studentid, [FromForm] IFormFile file, CancellationToken cancellationToken)
	     public async Task<IActionResult> UploadProfilePicture(int studentid, IFormFile file, CancellationToken cancellationToken)

		{
			if (file == null || file.Length == 0) { 
				return BadRequest("No file uploaded.");
			}

			await  using var stream = file.OpenReadStream();

			var newurl = await _studentService.UploadProfilePictureAsync(studentid, stream, file.FileName, file.ContentType, file.Length, cancellationToken);
			
			
			return Ok(newurl);
		}


	}
}
