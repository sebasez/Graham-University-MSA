using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrahamUniversity.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GrahamUniversity.WebApp.ViewComponents
{
    public class RatingsByStudentViewComponent : ViewComponent
    {
        private readonly IUnitOfWork unitOfWork;
        public RatingsByStudentViewComponent(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var ratings = await unitOfWork.Ratings.GetRatingsByStudentId(id);
            return View(ratings);
        }
    }
}
