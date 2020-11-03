using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using GrahamUniversity.Application.Interfaces;
using GrahamUniversity.Core.Entities;
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

        public IActionResult ListStudents() {
            return ViewComponent("ListStudents");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Student student, List<int> subjects)
        {
            using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var resultStudent = await unitOfWork.Student.AddAsync(student);
                    foreach (var item in subjects)
                    {
                        var result = await unitOfWork.Subject.AddAsync(new Subject { Id = item }, resultStudent);
                    }
                    ts.Complete();
                    return View(nameof(Index));
                }
                catch (Exception ex)
                {
                    ts.Dispose();
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
