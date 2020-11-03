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
    public class SubjectRepository : ISubjectRepository
    {
        private readonly IConfiguration configuration;
        public SubjectRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<int> AddAsync(Subject entity, int studentId)
        {
            var sql = "SP_AddSubjectStudent";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryFirstAsync<int>(sql, new { SubjectId=entity.Id, StudentId = studentId }, commandType: System.Data.CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<IReadOnlyList<Subject>> GetAllAsync()
        {
            var sql = "SP_GetSubject";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Subject>(sql, commandType: System.Data.CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<Subject> GetByIdAsync(int id)
        {
            var sql = "SP_GetSubject";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<Subject>(sql, new { Id = id }, commandType: System.Data.CommandType.StoredProcedure);
                return result;
            }
        }
    }
}
