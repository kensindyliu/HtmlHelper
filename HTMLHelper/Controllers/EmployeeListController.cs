using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTMLHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace HTMLHelper.Controllers
{
    public class EmployeeListController : Controller
    {
        public IActionResult Index()
        {
            EmployeeBusinessLogic em = new();
            var employees = em.GetEmployees();
            return View(employees);
        }

        public IActionResult Edit()
        {
            EmployeeBusinessLogic em = new();
            return View(em.GetEditingEmployee());
        }
    }
}