using GrahamUniversity.Application.Interfaces;

namespace GrahamUniversity.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IClassRoomRepository classRoomRepository,
            IRatingsRepository ratingsRepository,
            IStudentRepository studentRepository,
            ISubjectRepository subjectRepository,
            ITeacherRepository teacherRepository)
        {
            ClassRoom = classRoomRepository;
            Ratings = ratingsRepository;
            Student = studentRepository;
            Subject = subjectRepository;
            Teacher = teacherRepository;
        }
        public IClassRoomRepository ClassRoom { get; set; }
        public IRatingsRepository Ratings { get; set; }
        public IStudentRepository Student { get; set; }
        public ISubjectRepository Subject { get; set; }
        public ITeacherRepository Teacher { get; set; }
    }
}
