﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View(new string[] {"C#", "Language", "Features"});
    }
}

