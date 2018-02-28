using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ColumbusArmyOrder.DAL;

namespace ColumbusArmyOrder.BL
{
    class ClassReports
    {
        public static DataTable selectQout(string first, string second, string third) 
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                 dt = DataAccessLayer.ExecuteTable("selectQout", CommandType.StoredProcedure,
                    DataAccessLayer.CreateParameter("@first", SqlDbType.VarChar, first),
                    DataAccessLayer.CreateParameter("@second", SqlDbType.VarChar, second),
                    DataAccessLayer.CreateParameter("@third", SqlDbType.VarChar, third));
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;
        }
        public static DataTable selectorder(string first, string second, string third)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                dt = DataAccessLayer.ExecuteTable("selectorder", CommandType.StoredProcedure,
                   DataAccessLayer.CreateParameter("@first", SqlDbType.VarChar, first),
                   DataAccessLayer.CreateParameter("@second", SqlDbType.VarChar, second),
                   DataAccessLayer.CreateParameter("@third", SqlDbType.VarChar, third));
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;
        }
        public static DataTable selectBill(string first, string second, string third)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                 dt = DataAccessLayer.ExecuteTable("selectBill", CommandType.StoredProcedure,
                    DataAccessLayer.CreateParameter("@first", SqlDbType.VarChar, first),
                    DataAccessLayer.CreateParameter("@second", SqlDbType.VarChar, second),
                    DataAccessLayer.CreateParameter("@third", SqlDbType.VarChar, third));
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;
        }
        public static DataTable selectNOOrder(string first, string second, string third)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                dt = DataAccessLayer.ExecuteTable("selectNOOrder", CommandType.StoredProcedure,
                   DataAccessLayer.CreateParameter("@first", SqlDbType.VarChar, first),
                   DataAccessLayer.CreateParameter("@second", SqlDbType.VarChar, second),
                   DataAccessLayer.CreateParameter("@third", SqlDbType.VarChar, third));
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;
        }
        public static DataTable sp_quotexeRep(string first, string second, string third)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                 dt = DataAccessLayer.ExecuteTable("sp_quotexeRep", CommandType.StoredProcedure,
                    DataAccessLayer.CreateParameter("@first", SqlDbType.VarChar, first),
                    DataAccessLayer.CreateParameter("@second", SqlDbType.VarChar, second),
                    DataAccessLayer.CreateParameter("@third", SqlDbType.VarChar, third));
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;
        }
        public static DataTable sp_quotNotexeRep(string first, string second, string third)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                 dt = DataAccessLayer.ExecuteTable("sp_quotNotexeRep", CommandType.StoredProcedure,
                    DataAccessLayer.CreateParameter("@first", SqlDbType.VarChar, first),
                    DataAccessLayer.CreateParameter("@second", SqlDbType.VarChar, second),
                    DataAccessLayer.CreateParameter("@third", SqlDbType.VarChar, third));
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;
        }
        public static DataTable sp_orderRep(string first, string second, string third)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                dt = DataAccessLayer.ExecuteTable("sp_orderRep", CommandType.StoredProcedure,
                   DataAccessLayer.CreateParameter("@first", SqlDbType.VarChar, first),
                   DataAccessLayer.CreateParameter("@second", SqlDbType.VarChar, second),
                   DataAccessLayer.CreateParameter("@third", SqlDbType.VarChar, third));
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;
        }
        public static int sp_addphonenum(string ret, string name, string waz, string mob, string land, string fax,string t) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_addphonenum", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@retb", SqlDbType.VarChar, ret),
                DataAccessLayer.CreateParameter("@fname", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@wazef", SqlDbType.VarChar, waz),
                DataAccessLayer.CreateParameter("@mobil", SqlDbType.VarChar, mob),
                DataAccessLayer.CreateParameter("@landnum", SqlDbType.VarChar, land),
                DataAccessLayer.CreateParameter("@fax", SqlDbType.VarChar, fax),
                DataAccessLayer.CreateParameter("@t",SqlDbType.VarChar,t));
            DataAccessLayer.Close();
            return i;
        }
        public static int UpdatePhone(int id,string ret, string name, string waz, string mob, string land, string fax, string t)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdatePhone", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@ret", SqlDbType.VarChar, ret),
                DataAccessLayer.CreateParameter("@fname", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@waz", SqlDbType.VarChar, waz),
                DataAccessLayer.CreateParameter("@mob", SqlDbType.VarChar, mob),
                DataAccessLayer.CreateParameter("@land", SqlDbType.VarChar, land),
                DataAccessLayer.CreateParameter("@fax", SqlDbType.VarChar, fax),
                DataAccessLayer.CreateParameter("@t", SqlDbType.VarChar, t));
            DataAccessLayer.Close();
            return i;
        }
        public static int DeletePhone(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeletePhone", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable allphone() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("allphone", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchphone(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchphone", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectAllQuotL(string l) 
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                 dt = DataAccessLayer.ExecuteTable("selectAllQuotL", CommandType.StoredProcedure,
                    DataAccessLayer.CreateParameter("@l", SqlDbType.VarChar, l));
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;
        }
        public static DataTable selectAllOrderL(string l)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessLayer.Open();
                 dt = DataAccessLayer.ExecuteTable("selectAllOrderL", CommandType.StoredProcedure,
                    DataAccessLayer.CreateParameter("@l", SqlDbType.VarChar, l));
            }
            finally
            {
                DataAccessLayer.Close();
            }
            return dt;
        }
    }
}
