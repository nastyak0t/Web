using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UsingModelCalc()
        {

            MyModel l = Calculate();

            return View(l);

        }

        public IActionResult ViewDataCalc()
        {

            ViewData["data"] = Calculate();

            return View();


        }

        public IActionResult ViewBagCalc()
        {
            ViewBag.data = Calculate();

            return View();

        }

        public IActionResult ServiceInjectionCalc()
        {

            return View();
        }

        public MyModel Calculate()
        {
            var rand = new Random();
            int value = rand.Next(0, 10);
            int value2 = rand.Next(0, 10);

            int divRes;
            try
            {
                divRes = value / value2;
            }
            catch (DivideByZeroException)
            {
                divRes = -1;
            }

            return new MyModel
            {
                first = value,
                second = value2,
                resPlus = value + value2,
                resMin = value - value2,
                resDiv = divRes,
                resMulti = value * value2
            };
        }
    }
}
