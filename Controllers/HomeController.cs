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
        public IActionResult AddComment(int projectId, string content)
        {
            if (!string.IsNullOrWhiteSpace(content))
            {
                var project = ProjectData.Projects.FirstOrDefault(p => p.Id == projectId);
                if (project != null)
                {
                    project.Comments ??= new List<CommentModel>();
                    project.Comments.Add(new CommentModel
                    {
                        Author = "Admin",
                        Text = content,
                        PostedAt = DateTime.Now
                    });
                }
            }

            return RedirectToAction("Detail", new { id = projectId });
        }
    }
}