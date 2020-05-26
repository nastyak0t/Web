using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class MultyStagedController : Controller
    {
        static MultyStaged MS = new MultyStaged();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp_Stage1()
        {
            MS.SignUp_Stage = 1;
            ViewBag.Stage = MS.SignUp_Stage;
            return View("SignUp");
        }

        [HttpPost]
        public IActionResult SignUp_Stage2(string email, string password, string confirmPassword, bool remember)
        {
            MS.SignUp_Stage = 2;
            MS.Email = email;
            MS.Password = password;
            MS.Remember = remember;
            ViewBag.Stage = MS.SignUp_Stage;
            return View("SignUp");
        }

        [HttpPost]
        public IActionResult SignUp_Stage3(string firstName, string secondName, string birthday, string gender)
        {
            MS.SignUp_Stage = 3;
            MS.FirstName = firstName;
            MS.SecondName = secondName;
            MS.Birthday = birthday;
            MS.Gender = gender;

            ViewBag.Stage = MS.SignUp_Stage;
            ViewBag.Email  = MS.Email;
            ViewBag.Password  = MS.Password;
            ViewBag.Remember  = MS.Remember;
            ViewBag.FirstName  = MS.FirstName;
            ViewBag.SecondName  = MS.SecondName;
            ViewBag.Birthday  = MS.Birthday;
            ViewBag.Gender  = MS.Gender;

            return View("SignUp");
        }

        [HttpGet]
        public IActionResult ResetPassword_Stage1()
        {
            MS.ResetPassword_Stage = 1;
            ViewBag.Stage = MS.ResetPassword_Stage;
            return View("ResetPassword");
        }

        [HttpPost]
        public IActionResult ResetPassword_Stage2_SendCode()
        {
            MS.ResetPassword_Stage = 2;
            ViewBag.Stage = MS.ResetPassword_Stage;
            return View("ResetPassword");
        }

        [HttpPost]
        public IActionResult ResetPassword_Stage2_HaveCode()
        {
            MS.ResetPassword_Stage = 2;
            ViewBag.Stage = MS.ResetPassword_Stage;
            return View("ResetPassword");
        }
    }
}