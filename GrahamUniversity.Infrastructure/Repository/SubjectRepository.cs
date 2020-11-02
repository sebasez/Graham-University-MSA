using Dapper;
using GrahamUniversity.Application.Interfaces;
using GrahamUniversity.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace GrahamUniversity.Infrastructure.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly IConfiguration configuration;
        public SubjectRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Task<IReadOnlyList<Subject>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Subject> GetByIdAsync(int id)
        {
            var sql = "SELECT Name FROM Subject WHERE Subject.Id = @Id;";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<Subject>(sql, new { Id = id });
                return result;
            }
        }
    }
}
