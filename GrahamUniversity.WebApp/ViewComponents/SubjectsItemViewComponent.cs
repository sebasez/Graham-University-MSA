using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrahamUniversity.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GrahamUniversity.WebApp.ViewComponents
{
    public class SubjectsItemViewComponent : ViewComponent
    {
        private readonly IUnitOfWork unitOfWork;
        public SubjectsItemViewComponent(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var subject = await unitOfWork.Subject.GetByIdAsync(id);
            return View(subject);
        }
    }
}
