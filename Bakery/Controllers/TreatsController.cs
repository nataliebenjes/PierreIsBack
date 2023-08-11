using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Bakery.Controllers
{
    [Authorize]
    public class TreatsController : Controller
    {
        private readonly BakeryContext _db;
        public TreatsController(BakeryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Treats.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Treat treat)
        {
            _db.Treats.Add(treat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddFlavor(int id)
        {
            Treat thisTreat = _db.Treats.FirstOrDefault(recipes => recipes.TreatId == id);
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
            return View(thisTreat);
        }
        [HttpPost]
        public ActionResult AddFlavor(Treat treat, int flavorId)
        {
            #nullable enable
                TreatFlavor? joinEntity = _db.TreatFlavors.FirstOrDefault(join => (join.FlavorId == flavorId && join.TreatId == treat.TreatId));
            #nullable disable
            if (joinEntity == null && flavorId != 0)
            {
                _db.TreatFlavors.Add(new TreatFlavor() { FlavorId = flavorId, TreatId = treat.TreatId });
                _db.SaveChanges();
            }
        return RedirectToAction("Details", new { id = treat.TreatId });
        }
        public ActionResult Details(int id)
        {
            Treat thisTreat = _db.Treats
                .Include(treat => treat.JoinEntities)
                .ThenInclude(join => join.Flavor)
                .FirstOrDefault(treat => treat.TreatId == id);
            return View(thisTreat);
        }
    }
}