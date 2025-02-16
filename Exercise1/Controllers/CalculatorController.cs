using Microsoft.AspNetCore.Mvc;

namespace Exercise1.Controllers
{
    public class CalculatorController : Controller
    {
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
    }
}
