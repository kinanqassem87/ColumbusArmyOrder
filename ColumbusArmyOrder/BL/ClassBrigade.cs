using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColumbusArmyOrder.DAL;
using System.Data;

namespace ColumbusArmyOrder.BL
{
    class ClassBrigade
    {
        public static int AddNewBrigade(string name, string description) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_AddNewBrigade", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@description", SqlDbType.VarChar, description));
            DataAccessLayer.Close();
            return i;
                
        }
        public static DataTable allBrigade() 
        {
            DataTable dt = new DataTable();
        try
        {
            DataAccessLayer.Open();
             dt = DataAccessLayer.ExecuteTable("sp_allBrigades", CommandType.StoredProcedure);
        }
        finally
        {
            DataAccessLayer.Close();
        }
            return dt;

        }
        public static DataTable searchBrigade(string name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_searchBrigades", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, name));
            DataAccessLayer.Close();
            return dt;

        }
        public static int UpdateBrigade(int id,string name, string description)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_updateBrigade", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@decription", SqlDbType.VarChar, description));
            DataAccessLayer.Close();
            return i;

        }
        public static int DeleteBrigade(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_deleteBrigade", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;

        }
        public static DataTable fillBrigade()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_fillBrigades", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;

        }
        public static DataTable cmbchangeBrigades(string name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_cmbchangeBrigades", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name));
            DataAccessLayer.Close();
            return dt;

        }
        public static int AddNewBattlion(int id,string name, string description)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addnewBattlion", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@description", SqlDbType.VarChar, description));
            DataAccessLayer.Close();
            return i;

        }
        public static DataTable sp_allBattalion()
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                 dt = DataAccessLayer.ExecuteTable("sp_allBattalion", CommandType.StoredProcedure);
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;

        }
        public static DataTable sp_searchBattalion(string name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_searchBattalion", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, name));
            DataAccessLayer.Close();
            return dt;

        }
        public static int sp_addbattalion(int id, string name, string description)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addbattalion", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@description", SqlDbType.VarChar, description));
            DataAccessLayer.Close();
            return i;

        }
        public static int sp_delbattalion(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_delbattalion", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;

        }
        public static DataTable sp_fillBattalion(string name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_fillBattalion", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name));
            DataAccessLayer.Close();
            return dt;

        }
        public static int sp_addsaraya(string name, string description, int idbrigade,int idbattalion)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addsaraya", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@description", SqlDbType.VarChar, description),
                DataAccessLayer.CreateParameter("@idbrigade", SqlDbType.Int, idbrigade),
                DataAccessLayer.CreateParameter("@idbattalion", SqlDbType.Int, idbattalion));
            DataAccessLayer.Close();
            return i;

        }
        public static DataTable sp_allSaraya()
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                 dt = DataAccessLayer.ExecuteTable("sp_allSaraya", CommandType.StoredProcedure);
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;

        }
        public static DataTable sp_searchSaraya(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_searchSaraya", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;

        }
        public static int sp_updatesarayab(int id, string name, string descr) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_updatesarayab", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@description", SqlDbType.VarChar, descr));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_deletesarayab(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_deletesarayab", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
