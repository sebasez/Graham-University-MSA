using GrahamUniversity.Application.Interfaces;
using GrahamUniversity.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrahamUniversity.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IRatingsRepository, RatingsRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<ITeacherRepository, TeacherRepository>();
            services.AddTransient<IClassRoomRepository, ClassRoomRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
