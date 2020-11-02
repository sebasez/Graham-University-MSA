using GrahamUniversity.Application.Interfaces;
using GrahamUniversity.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrahamUniversity.Infrastructure.Repository
{
    public class TeacherRepository : ITeacherRepository
    { 
        private readonly IConfiguration configuration;
        public TeacherRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Task<IReadOnlyList<Teacher>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
