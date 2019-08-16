// using Microsoft.AspNetCore.Mvc;
// using Market.Models;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
//
// namespace Market.Controllers
// {
//   public class TreatsController : Controller
//   {
//     private readonly MarketContext _db;
//
//     public TreatsController(MarketContext db)
//     {
//       _db = db;
//     }
//
//     public ActionResult Index()
//     {
//       List<Treat> model = _db.Treats.ToList();
//       return View(model);
//     }
//
//     public ActionResult Create()
//     {
//       return View();
//     }
//
//     [HttpPost]
//     public ActionResult Create(Treat category)
//     {
//       _db.Treats.Add(category);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//
//     public ActionResult Details(int id)
//     {
//       var thisTreat = _db.Treats
//         .Include(category => category.Flavors)
//         .ThenInclude(join => join.Flavor)
//         .FirstOrDefault(category => category.TreatId == id);
//     return View(thisTreat);
//     }
//
//     public ActionResult Edit(int id)
//     {
//       var thisTreat = _db.Treats.FirstOrDefault(category => category.TreatId == id);
//       return View(thisTreat);
//     }
//
//     [HttpPost]
//     public ActionResult Edit(Treat category)
//     {
//       _db.Entry(category).State = EntityState.Modified;
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//
//     public ActionResult Delete(int id)
//     {
//       var thisTreat = _db.Treats.FirstOrDefault(category => category.TreatId == id);
//       return View(thisTreat);
//     }
//
//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//       var thisTreat = _db.Treats.FirstOrDefault(category => category.TreatId == id);
//       _db.Treats.Remove(thisTreat);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//   }
// }
