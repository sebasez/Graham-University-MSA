using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GrahamUniversity.Core.Entities
{
    public class Person : Entity
    {
        [Display(Name="Nombres")]
        public string Name { get; set; }

        [Display(Name = "Apellidos")]
        public string LastName { get; set; }
    }
}
