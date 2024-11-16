using Microsoft.AspNetCore.Mvc;
using C__Cumulative_1.Models;
using C__Cumulative_1.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TeacherAPIController : ControllerBase
{
    private readonly SchoolDbContext _context;

    public TeacherAPIController(SchoolDbContext context)
    {
        _context = context;
    }

    // Get all teachers
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
    {
        return await _context.Teachers.ToListAsync();
    }

    // Get teacher by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<Teacher>> GetTeacher(int id)
    {
        var teacher = await _context.Teachers.FindAsync(id);

        if (teacher == null)
        {
            return NotFound();
        }

        return teacher;
    }
}

