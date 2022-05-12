using Leave_Application.Data;
using Leave_Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Leave_Application.Pages
{
    public class RequestsModel : PageModel
    {
        private readonly RequestsDbContext _context;

        public RequestsModel(RequestsDbContext context) => _context = context;

        public async void OnGet()
        {
            Requests = await _context.Requests.Where(i => i.FirstName != null)
                .OrderBy(i => i.Id)
                .ToListAsync();
        }
        public IEnumerable<Requests> Requests { get; set; } = Enumerable.Empty<Requests>();
    }
}
