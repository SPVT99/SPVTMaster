using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SPVTMaster.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace SPVTMaster.Controllers
{
    public class CarsController : Controller
    {
        private readonly AutomobileContext _context;

        public CarsController(AutomobileContext context)
        {
            _context = context;
        }




        // GET: Cars
        public async Task<IActionResult> Index(string carsMake, string searchString)
        {


            var cars = from m in _context.Cars
                       select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(s => s.Make.Contains(searchString));

            }
            if (!String.IsNullOrEmpty(carsMake))
            {
                cars = cars.Where(x => x.Make == (carsMake));
            }

            var carsMakeVM = new CarsMakeViewModel();

            // USE LINQ to get list of make //
            IQueryable<string> MakeQuery = from c in _context.Cars
                                           orderby c.Make
                                           select c.Make;
            carsMakeVM.Make = new SelectList(await MakeQuery.Distinct().ToListAsync());
            carsMakeVM.cars = await cars.ToListAsync();

            return View(carsMakeVM);


            //return View(await _context.Cars.ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cars == null)
            {
                return NotFound();
            }

            return View(cars);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            //VehicleViolationList db = new VehicleViolationList();
            //List<VehicleViolationList> list = db.VehicleViolation.ToList();
            //ViewBag.VehicleViolationList = list;

            //{
            //new SelectListItem {Value="1", Text="You must only park in 1 parking space at a time"},
            //new SelectListItem {Value="2", Text="You must only park in designated parking spaces"},
            //new SelectListItem {Value="3", Text="You must pull forward into a parking space. Do not pull through or back into any parking spaces."},
            //new SelectListItem {Value="4", Text="You must have an Amazon-issued carpool sign in order to park in designated carpool spaces."},
            //new SelectListItem {Value ="5", Text="You must have a handicapped license plate, or current temporary placard in your front window in order to park in handicapped parking spaces."}
            //};

            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Make,Model,Color,licensePlate,DateTime,Description")] Cars cars)
        {

            if (ModelState.IsValid)
            {
                cars.DateTimeStamp = DateTime.Now;
                _context.Add(cars);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cars);
        }




        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars.SingleOrDefaultAsync(m => m.Id == id);
            if (cars == null)
            {
                return NotFound();
            }
            return View(cars);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Make,Model,Color,licensePlate,DateTime,Description")] Cars cars)
        {
            if (id != cars.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cars);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarsExists(cars.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cars);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cars == null)
            {
                return NotFound();
            }

            return View(cars);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cars = await _context.Cars.SingleOrDefaultAsync(m => m.Id == id);
            _context.Cars.Remove(cars);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarsExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }
}