using System.Security.AccessControl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		public class User
		{
			public int Id { get; set; }
			public string ?Name { get; set; }
			public string ?Email { get; set; }
		}
		[HttpGet]
		[Route("GetAll")]
		public async Task<IActionResult> GetAll() {

			var users = new List<User>
			{
				new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
				new User { Id = 2, Name = "Bob", Email = "bob@example.com" },
				new User { Id = 3, Name = "Charlie", Email = "charlie@example.com" },
				new User { Id = 4, Name = "Diana", Email = "diana@example.com" },
				new User { Id = 5, Name = "Edward", Email = "edward@example.com" }
			};

			return await Task.FromResult(Ok(users));

		}

	}
}
