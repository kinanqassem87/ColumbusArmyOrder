using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColumbusArmyOrder.DAL;
using System.Data;

namespace ColumbusArmyOrder.BL
{
    class ClassMilitaryPieces
    {
        public static int sp_addMilitaryP(string name, string descr) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addMilitaryP", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@descr", SqlDbType.VarChar, descr));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_allMilitaryPieces() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_allMilitaryPieces", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_searchMilitaryPieces(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_searchMilitaryPieces", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_UpdateMilitaryPieces(int id, string name, string descr) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_UpdateMilitaryPieces", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@descrip", SqlDbType.VarChar, descr));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_DeleteMilitaryPieces(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_DeleteMilitaryPieces", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
