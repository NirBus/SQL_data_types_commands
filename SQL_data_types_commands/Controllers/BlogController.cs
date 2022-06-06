using Microsoft.AspNetCore.Mvc;
using SQL_data_types_commands.DAL;
using SQL_data_types_commands.Models;
using System.Collections.Generic;
using System.Linq;

namespace SQL_data_types_commands.Controllers
{
    public class BlogController:Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.ToList();
            return View(blogs);
        }
    }
}
