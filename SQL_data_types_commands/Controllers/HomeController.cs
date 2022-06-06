﻿using Microsoft.AspNetCore.Mvc;
using SQL_data_types_commands.DAL;

namespace SQL_data_types_commands.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
       public IActionResult Index()
        {
            return View();
        }
    }
}
