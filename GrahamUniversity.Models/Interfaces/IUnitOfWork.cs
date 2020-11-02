using System;
using System.Collections.Generic;
using System.Text;

namespace GrahamUniversity.Application.Interfaces
{
    public interface IUnitOfWork
    {
        public IClassRoomRepository ClassRoom { get; set; }
        public IRatingsRepository Ratings { get; set; }
        public IStudentRepository Student { get; set; }
        public ISubjectRepository Subject { get; set; }
        public ITeacherRepository Teacher { get; set; }
    }
}
