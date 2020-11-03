using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrahamUniversity.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GrahamUniversity.WebApp.ViewComponents
{
    public class CreateStudentViewComponent : ViewComponent
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateStudentViewComponent(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
