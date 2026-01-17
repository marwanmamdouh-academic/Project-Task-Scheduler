using MarwanMamdohW2_0523016.Models;
using MarwanMamdohW2_0523016.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarwanMamdohW2_0523016.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AppDbContext db;
        public ProjectController(AppDbContext db)
        {
            this.db = db;
        }
        public async Task <IActionResult> Index()
        {
            var p = await db.projects.ToListAsync();
            return View(p);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Project p1)
        {
            await db.projects.AddAsync(p1);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var p = await db.projects.FirstOrDefaultAsync(x => x.Projectid == id);
            return View(p);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Project p1)
        {
            db.projects.Remove(p1);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var p = await db.projects.FirstOrDefaultAsync(x => x.Projectid == id);
            return View(p);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Project project)
        {
            db.projects.Update(project);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int id)
        {
            var p = await db.projects.Include(x => x.tasks).ThenInclude( x=> x.member).FirstOrDefaultAsync(x => x.Projectid == id);
            return View(p);
        }
        //maro
    }
}
