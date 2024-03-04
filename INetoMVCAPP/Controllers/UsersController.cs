using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using INetoMVCAPP.Models;

namespace INetoMVCAPP.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult INView()
        {
            return View(uc.InetoTables.ToList());
        }
    }
}