using Microsoft.AspNetCore.Mvc;
using School.ApplicationUser.Services.Interfaces;
using School.Domain.Models.DTOs;
using School.Domain.Models.Entities;

namespace School.Web.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class StudentController : ControllerBase
	{

		private readonly IStudentService _studentService;

		public StudentController(IStudentService studentService)
		{
			_studentService = studentService;
		}

		//C R U D
		[HttpGet]  // read
		public async Task<IActionResult> GetAllStudents(CancellationToken cancellationToken)
		{
			var students = await _studentService.GetAllStudetnsAsync(cancellationToken);

		
			return Ok(students);  // 200  201 204  400 404 403 //5
		}

		[HttpGet("{id:int}")]    // read
		public async Task<IActionResult> GetStudent(int id, CancellationToken cancellationToken)
		{
			var student = await _studentService.GetStudentByIdAsync(id, cancellationToken);

			return Ok(student);
		}

		//[HttpGet]    // read
		//public async Task<IActionResult> GetStudent( int id, CancellationToken cancellationToken)
		//{ 
		//	var student = await _studentService.GetStudentByIdAsync(id, cancellationToken);

		//	return Ok(student);
  //       }

		[HttpPost]  // Create
		public async Task<ActionResult<StudentDTO>> AddStudent(
			CreateStudentDTO createStudentDto, CancellationToken cancellationToken)
		{

			if (createStudentDto == null)
			{
				return BadRequest("Invalid data.");
			}

			var student = await _studentService.AddStudentAsync(createStudentDto, cancellationToken);

			return CreatedAtAction(
				nameof(GetStudent),
				new { id = student.Id },
				student
				
				); // 201
		}


		[HttpPut("{id:int}")]  // Update
		public async Task<IActionResult> UpdateStudent(int id,UpdateStudentDTO updateStudentDto, CancellationToken cancellationToken)
		{
			await _studentService.UpdateStudentAsync(id, updateStudentDto, cancellationToken);
			return NoContent(); // 204
		}


		[HttpDelete("{id:int}")]   // delete
		public async Task<IActionResult> DeleteStudent(int id, CancellationToken cancellationToken)
		{
			await _studentService.DeleteStudentAsync(id, cancellationToken);
			return NoContent(); // 204
		}



	}
}
