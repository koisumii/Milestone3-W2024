/*
 * Course: Web Programming 3
 * Assessment: Milestone 3
 * Created by: Rania Mustafa - 2256255
 * Date: 23 November 2024
 * Class Name: HomeController.cs
 * Description: Handles home page requests, provides the index view, and manages errors with ResponseCache and ErrorViewModel
 * Time Task B) 3 hours
*/
using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPlusSport.Security.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // var x = 1 / new Random().Next(0, 1);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
