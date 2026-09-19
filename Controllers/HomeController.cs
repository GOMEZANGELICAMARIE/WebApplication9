using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private bool IsLoggedIn() => HttpContext.Session.GetString("IsAuthenticated") == "true";

        
        public IActionResult Index()
        {
            if (!IsLoggedIn()) return RedirectToAction("Login", "Account");

            var projects = ProjectData.Projects;
            return View(projects);
        }

        
        public IActionResult Detail(int id)
        {
            if (!IsLoggedIn()) return RedirectToAction("Login", "Account");

            var project = ProjectData.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return NotFound();

            return View(project);
        }

        
        [HttpPost]
        public IActionResult AddComment(int projectId, string commentText)
        {
            if (!IsLoggedIn()) return RedirectToAction("Login", "Account");

            var project = ProjectData.Projects.FirstOrDefault(p => p.Id == projectId);
            if (project != null && !string.IsNullOrWhiteSpace(commentText))
            {
                string currentUser = HttpContext.Session.GetString("Username") ?? "Guest";
                project.Comments.Add(new CommentModel
                {
                    Author = currentUser,
                    Text = commentText,
                    PostedAt = DateTime.Now
                });
            }

            return RedirectToAction("Detail", new { id = projectId });
        }
    }
}