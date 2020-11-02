using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrahamUniversity.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GrahamUniversity.WebApp.Controllers
{
    public class StudentController : Controller
    {

        private readonly IUnitOfWork unitOfWork;
        public StudentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Student(int id)
        {
            var student = await unitOfWork.Student.GetByIdAsync(id);
            return View(student);
        }
    }
}
