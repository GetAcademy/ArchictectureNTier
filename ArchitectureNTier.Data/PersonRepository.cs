using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using ArchitectureNTier.Data.Model;
using Dapper;

namespace ArchitectureNTier.Data
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<IEnumerable<Person>> ReadChildren(int parentId)
        {
            var whereClause = " Father = @Id OR Mother = @Id ";
            return await ReadMany(whereClause, new { Id = parentId});
        }
    }
}
