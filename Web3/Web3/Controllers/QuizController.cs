using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class QuizController : Controller
    {
        static Random rnd = new Random();
        static QuizModel quiz = new QuizModel();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quiz()
        {
            ViewBag.numb1 = rnd.Next(10);
            ViewBag.numb2 = rnd.Next(10);
            return View();
        }

        public IActionResult QuizResult()
        {
            ViewBag.ListResult = quiz.listResult;
            ViewBag.RightAnswersCount = quiz.rightAnswersCount;
            ViewBag.AnswersCount = quiz.answersCount;
            return View();
        }

        [HttpPost]
        public IActionResult Next(string value1, string value2, string answer)
        {
            int Value1 = Convert.ToInt32(value1);
            int Value2 = Convert.ToInt32(value2);
            int Answer = Convert.ToInt32(answer);

            quiz.listResult.Add(Value1 + " + " + Value2 + " = " + Answer);
            quiz.answersCount++;

            if (Value1 + Value2 == Answer)
            {
                quiz.rightAnswersCount++;
            }            

            ViewBag.numb1 = rnd.Next(10);
            ViewBag.numb2 = rnd.Next(10);

            return View("quiz");
        }

        [HttpPost]
        public IActionResult Finish()
        {
            ViewBag.ListResult = quiz.listResult;
            ViewBag.RightAnswersCount = quiz.rightAnswersCount;
            ViewBag.AnswersCount = quiz.answersCount;
            return View("quizResult");
        }
    }
}