using Exercise2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student, IFormFile avatar)
        {
            // Save file
            if (avatar != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", avatar.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    avatar.CopyTo(stream);
                }
                student.Avatar = avatar.FileName;
            } 
            else
            {
                student.Avatar = "default.png";
            }

            // Replace the student data to the student.txt file
            System.IO.File.WriteAllText("student.txt", student.Id + "\n" 
                + student.Name + "\n" 
                + student.DateOfBirth + "\n" 
                + student.Gender + "\n"
                + student.Address + "\n"
                + student.Phone + "\n"
                + student.Avatar);

            return RedirectToAction("Details");
        }

        public IActionResult Details()
        {
            try
            {
                // Read the student data from the student.txt file
                string[] lines = System.IO.File.ReadAllLines("student.txt");

                // Create a new Student object
                Student student = new Student();

                // Set the properties of the Student object
                student.Id = int.Parse(lines[0]);
                student.Name = lines[1];
                student.DateOfBirth = DateTime.Parse(lines[2]);
                student.Gender = lines[3];
                student.Address = lines[4];
                student.Phone = lines[5];
                student.Avatar = lines[6];

                // Pass the Student object to the view
                return View(student);
            } 
            catch 
            { 
                return RedirectToAction("Index"); 
            }

        }
    }
}
