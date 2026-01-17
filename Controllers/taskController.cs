using MarwanMamdohW2_0523016.Models;
using MarwanMamdohW2_0523016.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarwanMamdohW2_0523016.Controllers
{
    public class taskController : Controller
    {
        private readonly AppDbContext db;
        public taskController(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Edit(int id)
        {
            var t = await db.tasks.FirstOrDefaultAsync(x => x.taskid == id);
            taskViewModel v1 = new taskViewModel()
            {
                Title = t.Title,
                Description = t.Description,
                Status = t.Status,
                teamMembers = await db.teamMembers.ToListAsync(),
                projects = await db.projects.ToListAsync(),
                memid = t.memid,
                pid = t.pid,
            };
            return View(v1);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(taskViewModel v1,int id)
        {
            var t = await db.tasks.FirstOrDefaultAsync(x => x.taskid == id); 
            t.Title = v1.Title;
            t.Description = v1.Description;
            t.Status = v1.Status;
            t.memid = v1.memid;
            t.pid = v1.pid;
            db.tasks.Update(t);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Project");
        }
       
    }
}
