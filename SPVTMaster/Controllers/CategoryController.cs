//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using SPVTMaster.Models;

//namespace SPVTMaster.Controllers
//{
//    public class CategoryController : Controller
//    {
//        private readonly AutomobileContext _context;
//        public CategoryController(AutomobileContext context) => _context = context;


//        // GET: Category
//       // public ActionResult Index(MainViewModel MainModel)
//       // {
//            //List<Category> clist = new List<Category>();
//            //clist.Add(new Category { ID = 1, Name = "You must only park in 1 parking space at a time" });
//            //clist.Add(new Category { ID = 2, Name = "You must only park in designated parking spaces" });
//            //clist.Add(new Category { ID = 3, Name = "You must pull forward into a parking space. Do not pull through or back into any parking spaces." });
//            //clist.Add(new Category { ID = 4, Name = "You must have an Amazon-issued carpool sign in order to park in designated carpool spaces." });
//            //clist.Add(new Category { ID = 5, Name = "You must have a handicapped license plate, or current temporary placard in your front window in order to park in 			    andicapped parking spaces." });
//            //MainViewModel cm = new MainViewModel();
//            //cm.ListCategory = clist;
//            //cm.SelectedAns = string.Empty;
//            //return View(cm);

//            ////-- Get Selected Value from radiobuttonlist 
//            //string SelectedValue = MainModel.SelectedAns;
//            ////-----------------------------------------------


//            ////-------------------------------------  Getting Data from Database Using EntityFramworkCore -------
//            //List<Category> categoryList = new List<Category>();

//            //categoryList = (from Category in _context.Category
//            //                select Category).ToList();

//            ////---------------------------  Creating Instance of MainViewModel and assiging value to ListCategory
//            //MainViewModel obj = new MainViewModel
//            //{
//            //    ListCategory = categoryList,
//            //    SelectedAns = string.Empty
//            //};
//            //return View(obj); //--------------- Sending MainViewModel to Index View
//        }

//        // GET: Category/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Category/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Category/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Category/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: Category/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Category/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Category/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}