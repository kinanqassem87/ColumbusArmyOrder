using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColumbusArmyOrder.DAL;
using System.Data;

namespace ColumbusArmyOrder.BL
{
    class ClassRegiments
    {
        public static int sp_addnewRegiment(string name, string Descrip) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addnewRegiment", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@descrip", SqlDbType.VarChar, Descrip));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_allRegiment() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_allRegiment", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_searchRegiment(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_searchRegiment", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_updateRegiment(int id, string name, string descr) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_updateRegiment", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@descr", SqlDbType.VarChar, descr));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_deleteRegiment(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_deleteRegiment", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_newSarayaR(string name,string descr,int regId) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_newSarayaR", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@descr", SqlDbType.VarChar, descr),
                DataAccessLayer.CreateParameter("@regId", SqlDbType.Int, regId));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_allSarayaR() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_allSarayaR", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_SearchSarayaR(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_SearchSarayaR", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_updateSarayaR(int id,string name,string descrp) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_updateSarayaR", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@descr", SqlDbType.VarChar, descrp));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_deleteSarayaR(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_deleteSarayaR", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable sp_FillSecondLRegQ(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_FillSecondLRegQ", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
    }
}
