using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = new[]
            {
                new Student { Id = 1, Name = "Percy", Address = "123 Main St", Gender = "Male", Age = 22 },
                new Student { Id = 2, Name = "Lava Girl", Address = "456 Elm St", Gender = "Female", Age = 20 },
                new Student { Id = 3, Name = "Heinsenberg", Address = "789 Oak St", Gender = "Male", Age = 23 },
                
                new Student { Id = 3, Name = "Pablo", Address = "789 Oak St", Gender = "Male", Age = 23 },
                
                new Student { Id = 3, Name = "Shark Boy", Address = "789 Oak St", Gender = "Male", Age = 23 }
            };

            return Ok(students); 
        }

        
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
           
            var student = new Student { Id = id, Name = "John Doe", Address = "123 Main St", Gender = "Male", Age = 22 };

            return student != null ? Ok(student) : NotFound(); 
        }
    }
}
