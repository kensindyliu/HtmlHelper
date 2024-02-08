using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTMLHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace HTMLHelper.Controllers
{
    public class EmployeeRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //empname,EmployeeName 是控件的名字，值则是控件的值要
        public ActionResult Register(string empname, string EmployeeName, string Gender, string Country, bool TnC)
        {
            // index is the name of action, == public IActionResult Index() here
            // EmployeeRegistration is the controller name
            //如果任何参数不正确，那么会跳转并显示一个空的页入
            Employee e1 = new();
            e1.EmployeeFirstName = empname;
            e1.EmployeeLastName = EmployeeName;
            e1.Country = Country;

            EmployeeBusinessLogic em = new();
            e1.EmployeeId = em.GetEmployees().Count;
            em.AddEmployee(e1);
            //em.AddEmployee(new Employee() {EmployeeId =2, Country = "US11", EmployeeLastName = "Liu", EmployeeFirstName = "abc" });
            return RedirectToAction("index", "EmployeeList");
            //return Redirect("Https://www.google.com/");
            //return View();
        }

        public ActionResult Delete(int EmployeeId)
        {
            EmployeeBusinessLogic eb = new();
            eb.DeleteEmployee(EmployeeId);
            return RedirectToAction("Index", "EmployeeList");
        }

        public ActionResult Edit(int EmployeeId)
        {
            EmployeeBusinessLogic eb = new();
            eb.EditEmployee(EmployeeId);
            return RedirectToAction("Edit", "EmployeeList");
        }
    }
}