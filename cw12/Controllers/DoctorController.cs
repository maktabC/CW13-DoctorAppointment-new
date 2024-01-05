using cw12.DataBase;
using cw12.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace cw12.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var x = Tempdatabase.doctors.Select(x => new SelectListItem { Text = x.LastName, Value = x.Id.ToString() }).ToList();
            ViewBag.Doctors = Tempdatabase.doctors;
            ViewData["Doctors"] = Tempdatabase.doctors;
            return View();
        }

        [HttpPost]
        public IActionResult AddReservation(Reservation reservation)
        {
            var targetDoctor = Tempdatabase.doctors.FirstOrDefault(x => x.Id == reservation.Doctor.Id);
            reservation.Doctor = targetDoctor;
            targetDoctor.Reservations.Add(reservation);
            Tempdatabase.reservations.Add(reservation);
            return RedirectToAction("Index");
        }
    }
}