using MarwanMamdohW2_0523016.Models;
using MarwanMamdohW2_0523016.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarwanMamdohW2_0523016.Controllers
{
    public class memberController : Controller
    {
        private readonly AppDbContext db;
        public memberController(AppDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var m = await db.teamMembers.Include(x => x.tasks).FirstOrDefaultAsync(x => x.TeamMemberid == id);
            return View(m);
        }
        public async Task <IActionResult> Edit(int id)
        {
            var m = await db.teamMembers.FirstOrDefaultAsync(x => x.TeamMemberid == id);
            return View(m);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(TeamMember m1)
        {
            db.teamMembers.Update(m1);
            await db.SaveChangesAsync();
            return RedirectToAction("Index","Project");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var m = await db.teamMembers.Include(x => x.tasks).FirstOrDefaultAsync(x => x.TeamMemberid == id);
            return View(m);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(TeamMember m1)
        {
            var t = await db.tasks.FirstOrDefaultAsync(x => x.memid == m1.TeamMemberid);
            db.tasks.Remove(t);
            db.teamMembers.Remove(m1);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Project");
        }
    }
}
