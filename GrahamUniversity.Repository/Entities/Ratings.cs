using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GrahamUniversity.Core.Entities
{
    public class Ratings : Entity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        [Display(Name="Materia")]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        [Display(Name = "Calificación")]
        public decimal Rating { get; set; }

        [Display(Name = "Fecha calificación")]
        public DateTime DateRating { get; set; }
        public DateTime? DateRatingUpdate { get; set; }
        public string DateShortRating { get { return DateRating.ToShortDateString(); } }
    }
}
