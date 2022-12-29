using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Travel2.Models;
using Travel2.Models.Domain;

namespace Travel2.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        public DashboardController(DatabaseContext databaseContext)
        {
                _databaseContext = databaseContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Book bookRequest)
        {
            var book = new Tour()
            {
                UserName = bookRequest.UserName,
                Usermail = bookRequest.Usermail,
                PhoneNumber = bookRequest.PhoneNumber,
                TypeOfTour = bookRequest.TypeOfTour,
                Message = bookRequest.Message,
                DateOfTour = bookRequest.DateOfTour
            };

           await _databaseContext.Tours.AddAsync(book);
           await _databaseContext.SaveChangesAsync();
            TempData["success"] = "Added successfully!!!";
            return RedirectToAction("Add");

        }

    }
}
