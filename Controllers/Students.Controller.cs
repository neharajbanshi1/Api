using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // Endpoint to get all students
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = new[]
            {
                new Student { Id = 1, Name = "Percy", Address = "123 Main St", Gender = "Male", Age = 22 },
                new Student { Id = 2, Name = "Lava Girl", Address = "456 Elm St", Gender = "Female", Age = 20 },
                new Student { Id = 3, Name = "Shark Boy", Address = "789 Oak St", Gender = "Male", Age = 23 }
            };

            return Ok(students); // Return list of students as JSON
        }

        // Endpoint to get a student by ID
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            // Example static student data for demo purposes
            var student = new Student { Id = id, Name = "John Doe", Address = "123 Main St", Gender = "Male", Age = 22 };

            return student != null ? Ok(student) : NotFound(); // Return student or 404 if not found
        }
    }
}
