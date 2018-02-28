using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ColumbusArmyOrder.DAL;

namespace ColumbusArmyOrder.BL
{
    class ClassUsers
    {
        public static DataTable SelectAllUser() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectAllUser", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int updatePassword(string upass, int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updatePassword", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@UPass", SqlDbType.VarChar, upass),
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
