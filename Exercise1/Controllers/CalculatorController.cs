using Exercise1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise1.Controllers
{
    public class CalculatorController : Controller
    {
        // Use Action Agruments
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string number1, string number2, string operation)
        {
            if (number1 == null || number2 == null)
            {
                return View();
            }

            double num1 = double.Parse(number1);
            double num2 = double.Parse(number2);

            double result = 1;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            TempData["Result"] = result;

            return View();
        }

        public IActionResult UseRequest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UseRequest(string operation)
        {
            if (Request.Form["number1"].FirstOrDefault() == null || Request.Form["number2"].FirstOrDefault() == null)
            {
                return View();
            }

            string number1 = Request.Form["number1"].ToString();
            string number2 = Request.Form["number2"].ToString();

            if (number1 == null || number2 == null)
            {
                return View();
            }

            double num1 = double.Parse(number1);
            double num2 = double.Parse(number2);

            double result = 1;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            TempData["Result"] = result;

            return View();
        }

        public IActionResult UseIFormCollection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UseIFormCollection(IFormCollection form)
        {
            string number1 = form["number1"].FirstOrDefault() ?? throw new ArgumentException("Number 1 is required");
            string number2 = form["number2"].FirstOrDefault() ?? throw new ArgumentException("Number 2 is required");
            string operation = form["operation"].FirstOrDefault() ?? throw new ArgumentException("Operation is required");

            if (number1 == null || number2 == null)
            {
                return View();
            }

            double num1 = double.Parse(number1);
            double num2 = double.Parse(number2);

            double result = 1;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            TempData["Result"] = result;

            return View();
        }

        public IActionResult UseModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UseModel(CalculateModel model)
        {
            if (model == null || model.Operation == null)
            {
                return View();
            }

            double result = 1;
            switch (model.Operation)
            {
                case "+":
                    result = model.Number1 + model.Number2;
                    break;
                case "-":
                    result = model.Number1 - model.Number2;
                    break;
                case "*":
                    result = model.Number1 * model.Number2;
                    break;
                case "/":
                    result = model.Number1 / model.Number2;
                    break;
            }
            TempData["Result"] = result;
            return View();
        }
    }
}
