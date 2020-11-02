using GrahamUniversity.Application.Interfaces;
using GrahamUniversity.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrahamUniversity.Infrastructure.Repository
{
    public class ClassRoomRepository : IClassRoomRepository
    {
        private readonly IConfiguration configuration;
        public ClassRoomRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Task<IReadOnlyList<ClassRoom>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ClassRoom> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
