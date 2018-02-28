using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColumbusArmyOrder.DAL;
using System.Data;

namespace ColumbusArmyOrder.BL
{
    class ClassBill
    {
        public static DataTable sp_orders(string code) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_orders", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@code", SqlDbType.VarChar, code));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_SearchOrders(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_SearchOrders", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_OrderDetailsSel(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_OrderDetailsSel", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_bill(DateTime dt, string contact, string first, string second, string third, string legal, string amount, string tva, string total,string code) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_bill", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@b_date", SqlDbType.Date, dt),
                DataAccessLayer.CreateParameter("@contact", SqlDbType.VarChar, contact),
                DataAccessLayer.CreateParameter("@FirstL", SqlDbType.VarChar, first),
                DataAccessLayer.CreateParameter("@second", SqlDbType.VarChar, second),
                DataAccessLayer.CreateParameter("@thirdL", SqlDbType.VarChar, third),
                DataAccessLayer.CreateParameter("@legal", SqlDbType.VarChar, legal),
                DataAccessLayer.CreateParameter("@Amount", SqlDbType.VarChar, amount),
                DataAccessLayer.CreateParameter("@TVA", SqlDbType.VarChar, tva),
                DataAccessLayer.CreateParameter("@Total", SqlDbType.VarChar, total),
                DataAccessLayer.CreateParameter("@code", SqlDbType.VarChar, code));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_billDet(string num, string type, string barcode, string qty, string unitprice, string totalprice) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_billDet", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@billnum", SqlDbType.VarChar, num),
                DataAccessLayer.CreateParameter("@billType", SqlDbType.VarChar, type),
                DataAccessLayer.CreateParameter("@barcode", SqlDbType.VarChar, barcode),
                DataAccessLayer.CreateParameter("@QTY", SqlDbType.VarChar, qty),
                DataAccessLayer.CreateParameter("@unitPrice", SqlDbType.VarChar, unitprice),
                DataAccessLayer.CreateParameter("@totalPrice", SqlDbType.VarChar, totalprice));
            DataAccessLayer.Close();
            return i;
        }
        public static int updExecuteOrder(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updExecuteOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
