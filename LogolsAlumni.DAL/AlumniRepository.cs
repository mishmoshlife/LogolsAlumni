using System.Collections.Generic;
using System.Data;
using System.Linq;
using LogolsAlumni.Entities;
using Dapper;

namespace LogolsAlumni.DAL
{
    public class AlumniRepository : Repository
    {
        public int Insert(Alumni alumni)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("dbo.InsertAlumni", new { FirstName = alumni.FirstName, LastName = alumni.LastName, Email = alumni.Email }, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public IEnumerable<Alumni> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Alumni>("dbo.GetAll", commandType: CommandType.StoredProcedure);
            }
        }

 /*
        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.DeleteMeasure", new { measure_id = id }, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Measure measure)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Team2.UpdateMeasure", measure, commandType: CommandType.StoredProcedure);
            }
        }

        public Measure Get(int measureID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Measure>("Team2.GetMeasure", new { measure_id = measureID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
   */

        
    }
}
 