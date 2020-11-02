using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrahamUniversity.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GrahamUniversity.WebApp.Controllers
{
    public class RatingsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public RatingsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RatingsByStudentId(int id)
        {
            var ratings = unitOfWork.Ratings.GetRatingsByStudentId(id);
            return PartialView(ratings);
        }
    }
}
