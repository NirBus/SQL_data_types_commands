﻿using Microsoft.AspNetCore.Mvc;

namespace SQL_data_types_commands.Controllers
{
    public class BlogController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
