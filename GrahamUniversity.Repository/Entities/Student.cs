using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GrahamUniversity.Core.Entities
{
    public class Student : Person
    {
        [Required(ErrorMessage = "La fecha es requerida")]
        [Display(Name = "Fecha ingreso")]
        public DateTime DateEntry { get; set; }

        [Display(Name = "Fecha ingreso")]
        public string DateEntryShort { get { return DateEntry.ToShortDateString(); } }
        public string FullName { get { return $"{Name} {LastName}"; } }
    }
}
