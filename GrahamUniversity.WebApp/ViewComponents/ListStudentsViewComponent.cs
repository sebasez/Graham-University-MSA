using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrahamUniversity.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GrahamUniversity.WebApp.ViewComponents
{
    public class ListStudentsViewComponent : ViewComponent
    {
        private readonly IUnitOfWork unitOfWork;
        public ListStudentsViewComponent(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var students = await unitOfWork.Student.GetAllAsync();
            return View(students);
        }
    }
}
