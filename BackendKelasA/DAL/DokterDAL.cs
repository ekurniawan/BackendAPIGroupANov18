using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using BackendKelasA.Models;

namespace BackendKelasA.DAL
{
    public class DokterDAL : IDokter
    {
        private IHelper _helper;
        public DokterDAL(IHelper helper)
        {
            _helper = helper;
        }

        public Task Delete(Dokter obj)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dokter>> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(_helper.GetConnectionString()))
            {
                string strSql = @"select * from Dokter order by Username asc";
                var results = await conn.QueryAsync<Dokter>(strSql);
                return results;
            }
        }

        public Task<Dokter> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Dokter obj)
        {
            throw new NotImplementedException();
        }

        public Task Update(Dokter obj)
        {
            throw new NotImplementedException();
        }
    }
}
