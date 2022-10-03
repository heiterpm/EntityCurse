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
    public class IndexModel : PageModel
    {
        private readonly EntityAspCurso.Data.SchoolContext _context;

        public IndexModel(EntityAspCurso.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Enrollment> Enrollment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Enrollments != null)
            {
                Enrollment = await _context.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Student).ToListAsync();
            }
        }
    }
}
