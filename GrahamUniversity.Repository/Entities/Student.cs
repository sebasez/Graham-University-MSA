using System;
using System.Collections.Generic;
using System.Text;

namespace GrahamUniversity.Core.Entities
{
    public class Student : Person
    {
        public string FullName { get { return $"{Name} {LastName}"; } }
    }
}
