using System.Data;
using System.Data.SqlClient;
using ULAPI.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ULAPI.Utils
{
    public class DataAccess : IDataAccess
    {
        private IUDBConnM UDBConnM;
        public DataAccess(IUDBConnM _UDBConnM)
        {
            UDBConnM = _UDBConnM;
        }

        public void addUser(UserModel user)
        {
            using (SqlConnection conn = new SqlConnection(UDBConnM.ConnStrUDB))
            {
                conn.Query<UserModel>($"dbo.addUser '{user.Name}', '{user.Password}', '{user.Email}'");
            }
        }
        public void removeUser(UserModel user)
        {
            using (SqlConnection conn = new SqlConnection(UDBConnM.ConnStrUDB))
            {
                conn.Query<UserModel>($"dbo.deleteUser '{user.Password}', '{user.Name}'");
            }
        }
        public void updateUser(UserModel user, UserModel newUser)
        {
            using (SqlConnection conn = new SqlConnection(UDBConnM.ConnStrUDB))
            {
                conn.Query<UserModel>($"dbo.editUser '{user.Password}', '{user.Name}', '{newUser.Name}', '{newUser.Password}', '{newUser.Email}'");
            }
        }
        public bool validateUser(UserModel user)
        {
            using (SqlConnection conn = new SqlConnection(UDBConnM.ConnStrUDB))
            {
                return conn.Query<bool>($"dbo.validateUser '{user.Password}', '{user.Name}'").FirstOrDefault();
            }
        }
    }
}
