using System;
using System.Collections.Generic;
using System.Text;

namespace GrahamUniversity.Core.Entities
{
    public class Subject : Entity
    {
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
