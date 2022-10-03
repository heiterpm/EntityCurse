using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntityAspCurso.Data;
using EntityAspCurso.Models;

namespace EntityAspCurso.Pages.Enrollments
{
    public class DetailsModel : PageModel
    {
        private readonly EntityAspCurso.Data.SchoolContext _context;

        public DetailsModel(EntityAspCurso.Data.SchoolContext context)
        {
            _context = context;
        }

      public Enrollment Enrollment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Enrollments == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollments.Include(s => s.Student).Include(c => c.Course).FirstOrDefaultAsync(m => m.EnrollmentID == id);
            if (enrollment == null)
            {
                return NotFound();
            }
            else 
            {
                Enrollment = enrollment;
            }
            return Page();
        }
    }
}
