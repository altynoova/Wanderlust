using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel2.Models.Domain;

namespace Travel2.Controllers
{
    [Authorize(Roles="admin")]
    public class AdminController : Controller
    {
       private readonly DatabaseContext _databaseContext;
            public AdminController(DatabaseContext databaseContext)
            {
                _databaseContext = databaseContext;
            }
            [HttpGet]
            public async Task<IActionResult> Display()
            {
            var book = await _databaseContext.Tours.ToListAsync();
            return View(book);
            }
            [HttpGet]
            public async Task<IActionResult> Delete(int id)
            {
                var book = await _databaseContext.Tours.FindAsync(id);
                if (book == null)
                {
                    return NotFound();
                }
                    _databaseContext.Tours.Remove(book);
                    await _databaseContext.SaveChangesAsync();
                return RedirectToAction("Display");
            }
    }
}
