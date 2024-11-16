using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using C__Cumulative_1.Models;  // Adjust according to your actual namespace
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C__Cumulative_1.Controllers
{
    public class TeacherPageController : Controller
    {
        private readonly SchoolDbContext _context;

        // Constructor to initialize the SchoolDbContext
        public TeacherPageController(SchoolDbContext context)
        {
            _context = context;
        }

        // Action to display the list of teachers
        public async Task<IActionResult> List()
        {
            // Fetching all teachers from the database
            var teachers = await _context.Teachers.ToListAsync();

            // Passing the list of teachers to the view
            return View(teachers); // Returns the List view with teacher data
        }

        // Action to display details of a specific teacher by ID
        public async Task<IActionResult> Show(int id)
        {
            // Fetching a specific teacher by ID
            var teacher = await _context.Teachers.FindAsync(id);

            // If teacher not found, return 404 Not Found response
            if (teacher == null)
            {
                return NotFound();  // Return 404 if teacher is not found
            }

            // Return the Show view with teacher data
            return View(teacher); // Returns the Show view with teacher data
        }
    }
}


