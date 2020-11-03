using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrahamUniversity.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GrahamUniversity.WebApp.ViewComponents
{
    public class ListSubjectViewComponent : ViewComponent
    {
        private readonly IUnitOfWork unitOfWork;
        public ListSubjectViewComponent(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var subjects = await unitOfWork.Subject.GetAllAsync();
            return View(subjects);
        }
    }
}
