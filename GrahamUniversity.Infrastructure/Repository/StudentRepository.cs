using Dapper;
using GrahamUniversity.Application.Interfaces;
using GrahamUniversity.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrahamUniversity.Infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IConfiguration configuration;
        public StudentRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Task<int> AddAsync(Student entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Student>> GetAllAsync()
        {
            var sql = "select * from Student";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Student>(sql);
                return result.ToList();
            }
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM Student WHERE Id = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Student>(sql, new { Id = id });
                return result;
            }
        }

        public Task<int> UpdateAsync(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
