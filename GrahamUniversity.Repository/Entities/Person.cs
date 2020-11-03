using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GrahamUniversity.Core.Entities
{
    public class Person : Entity
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name="Nombres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El apillido es obligatorio")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El número de documento es obligatorio")]
        [Display(Name = "Número de documento")]
        public string DocumentNumber { get; set; }
    }
}
