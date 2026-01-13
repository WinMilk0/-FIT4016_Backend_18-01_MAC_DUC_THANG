using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private const int PageSize = 10;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Students?page=1
        public async Task<IActionResult> Index(int page = 1)
        {
            var query = _context.Students.Include(s => s.School).OrderBy(s => s.FullName);
            var totalItems = await query.CountAsync();
            var students = await query.Skip((page - 1) * PageSize).Take(PageSize).ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

            return View(students);
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var student = await _context.Students.Include(s => s.School).FirstOrDefaultAsync(m => m.Id == id);
            if (student == null) return NotFound();

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            PopulateSchoolsDropDown();
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SchoolId,FullName,StudentId,Email,Phone")] Student student)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    PopulateSchoolsDropDown(student.SchoolId);
                    return View(student);
                }

                // Validate school exists
                var schoolExists = await _context.Schools.AnyAsync(s => s.Id == student.SchoolId);
                if (!schoolExists)
                {
                    ModelState.AddModelError("SchoolId", "Selected school does not exist.");
                    PopulateSchoolsDropDown(student.SchoolId);
                    return View(student);
                }

                // Check uniqueness
                if (await _context.Students.AnyAsync(s => s.StudentId == student.StudentId))
                {
                    ModelState.AddModelError("StudentId", "Student ID already exists.");
                    PopulateSchoolsDropDown(student.SchoolId);
                    return View(student);
                }

                if (await _context.Students.AnyAsync(s => s.Email == student.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists.");
                    PopulateSchoolsDropDown(student.SchoolId);
                    return View(student);
                }

                student.CreatedAt = DateTime.UtcNow;
                student.UpdatedAt = DateTime.UtcNow;

                _context.Add(student);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Student created successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                // Log exception (omitted for brevity)
                ModelState.AddModelError(string.Empty, "An error occurred while creating the student. Please try again.");
                PopulateSchoolsDropDown(student.SchoolId);
                return View(student);
            }
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var student = await _context.Students.FindAsync(id);
            if (student == null) return NotFound();

            PopulateSchoolsDropDown(student.SchoolId);
            return View(student);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SchoolId,FullName,StudentId,Email,Phone")] Student student)
        {
            if (id != student.Id) return NotFound();

            try
            {
                if (!ModelState.IsValid)
                {
                    PopulateSchoolsDropDown(student.SchoolId);
                    return View(student);
                }

                // Validate school
                if (!await _context.Schools.AnyAsync(s => s.Id == student.SchoolId))
                {
                    ModelState.AddModelError("SchoolId", "Selected school does not exist.");
                    PopulateSchoolsDropDown(student.SchoolId);
                    return View(student);
                }

                // Check uniqueness excluding current
                if (await _context.Students.AnyAsync(s => s.StudentId == student.StudentId && s.Id != student.Id))
                {
                    ModelState.AddModelError("StudentId", "Student ID already exists.");
                    PopulateSchoolsDropDown(student.SchoolId);
                    return View(student);
                }

                if (await _context.Students.AnyAsync(s => s.Email == student.Email && s.Id != student.Id))
                {
                    ModelState.AddModelError("Email", "Email already exists.");
                    PopulateSchoolsDropDown(student.SchoolId);
                    return View(student);
                }

                var existing = await _context.Students.FindAsync(id);
                if (existing == null) return NotFound();

                // Update fields
                existing.FullName = student.FullName;
                existing.Email = student.Email;
                existing.Phone = student.Phone;
                existing.SchoolId = student.SchoolId;
                existing.UpdatedAt = DateTime.UtcNow;

                _context.Update(existing);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Student updated successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Please try again or contact support.");
                PopulateSchoolsDropDown(student.SchoolId);
                return View(student);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred.");
                PopulateSchoolsDropDown(student.SchoolId);
                return View(student);
            }
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var student = await _context.Students.Include(s => s.School).FirstOrDefaultAsync(m => m.Id == id);
            if (student == null) return NotFound();

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var student = await _context.Students.FindAsync(id);
                if (student == null) return NotFound();

                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Student deleted successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the student.";
                return RedirectToAction(nameof(Index));
            }
        }

        private void PopulateSchoolsDropDown(object? selected = null)
        {
            var schools = _context.Schools.OrderBy(s => s.Name).Select(s => new { s.Id, s.Name }).ToList();
            ViewBag.Schools = new SelectList(schools, "Id", "Name", selected);
        }
    }
}