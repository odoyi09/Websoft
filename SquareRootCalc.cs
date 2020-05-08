using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Websoft.Controllers
{
    public class SquareRootCalc: Controller
{
    [HttpGet]
    public ActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Add(string firstNumber, string secondNumber)
    {
        ViewBag.firstNumber = firstNumber;
            ViewBag.secondNumber = secondNumber;
            int Num1 = 0;
            bool isConverted1 = int.TryParse(firstNumber, out Num1);

            int Num2 = 0;
            bool isConverted2 = int.TryParse(firstNumber, out Num2);

            int SQNum1 = (int)Math.Sqrt(Num1);
            int SQNum2 = (int)Math.Sqrt(Num2);

            ViewBag.SQNum1 = SQNum1;
            ViewBag.SQNum2 = SQNum2;

            ViewBag.isConverted1 = isConverted1;
            ViewBag.isConverted2 = isConverted2;

            ViewBag.Num1 = Num1;
            ViewBag.Num2 = Num2;
        return View();

    }
    }
}