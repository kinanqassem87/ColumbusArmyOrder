using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColumbusArmyOrder.DAL;
using System.Data;

namespace ColumbusArmyOrder.BL
{
    class ClassOrder
    {
        public static DataTable sp_selectQuotaions(string code) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_selectQuotaions", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@code", SqlDbType.VarChar, code));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_searchSelectedQuotaions(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_searchSelectedQuotaions", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_IDSelectedQuotaionsDet(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_IDSelectedQuotaionsDet", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_broOrder(DateTime dt, string contact, string first, string second, string third, string legal,string code) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_broOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Date", SqlDbType.Date, dt),
                DataAccessLayer.CreateParameter("@Contact", SqlDbType.VarChar, contact),
                DataAccessLayer.CreateParameter("@FirstL", SqlDbType.VarChar, first),
                DataAccessLayer.CreateParameter("@SecondL", SqlDbType.VarChar, second),
                DataAccessLayer.CreateParameter("@thirdL", SqlDbType.VarChar, third),
                DataAccessLayer.CreateParameter("@Order_Legal", SqlDbType.VarChar, legal),
                DataAccessLayer.CreateParameter("@code", SqlDbType.VarChar, code));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_briOrderDet(string num, string type, string barcode, string qty) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_briOrderDet", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@OrderNum", SqlDbType.VarChar, num),
                DataAccessLayer.CreateParameter("@OrderType", SqlDbType.VarChar, type),
                DataAccessLayer.CreateParameter("@OrderBarcode", SqlDbType.VarChar, barcode),
                DataAccessLayer.CreateParameter("@Qty", SqlDbType.VarChar, qty));
            DataAccessLayer.Close();
            return i;
        }
        public static int briUpdateQuotExE(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("briUpdateQuotExE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }

    }
}
