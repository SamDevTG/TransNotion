using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransNotion.Data;
using Models;

namespace TransNotion.Controllers
{
    public class TasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tasks
        public async Task<IActionResult> Index()
        {
            var tasks = await _context.Tasks.Include(t => t.User).ToListAsync();
            return View(tasks);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,DueDate,Priority,IsCompleted")] Tasks task)
        {
            if (ModelState.IsValid)
            {
                task.UserId = 1; // Ajuste conforme a autenticação do usuário
                _context.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }
    }
}
