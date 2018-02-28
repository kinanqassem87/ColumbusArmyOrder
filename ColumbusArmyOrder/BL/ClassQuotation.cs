using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColumbusArmyOrder.DAL;
using System.Data;

namespace ColumbusArmyOrder.BL
{
    class ClassQuotation
    {
        public static DataTable sp_fillBattQout(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_fillBattQout", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable sp_fillSaraQout(int idBri,int idBat)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_fillSaraQout", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@idBri", SqlDbType.Int, idBri),
                DataAccessLayer.CreateParameter("@idReg", SqlDbType.Int, idBat));
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_AddNewQuotation(DateTime dt, string contact, string first, string second, string third, string legal, string excut,string Q_code) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_AddNewQuotation", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Quot_Date", SqlDbType.Date, dt),
                DataAccessLayer.CreateParameter("@ContactN", SqlDbType.VarChar, contact),
                DataAccessLayer.CreateParameter("@FirstL", SqlDbType.VarChar, first),
                DataAccessLayer.CreateParameter("@SecondL", SqlDbType.VarChar, second),
                DataAccessLayer.CreateParameter("@thirdL", SqlDbType.VarChar, third),
                DataAccessLayer.CreateParameter("@QoutLegal", SqlDbType.VarChar, legal),
                DataAccessLayer.CreateParameter("@QuotExcute", SqlDbType.VarChar, excut),
                DataAccessLayer.CreateParameter("@Q_code", SqlDbType.VarChar, Q_code));
            DataAccessLayer.Close();
            return i;
        }
        public static int sp_isertDetails(string num, string type, string barcode, string qty, string price, string specific) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_isertDetails", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@DetNum", SqlDbType.VarChar, num),
                DataAccessLayer.CreateParameter("@QoutType", SqlDbType.VarChar, type),
                DataAccessLayer.CreateParameter("@QoutBarcode", SqlDbType.VarChar, barcode),
                DataAccessLayer.CreateParameter("@QoutQty", SqlDbType.VarChar, qty),
                DataAccessLayer.CreateParameter("@QoutPrice", SqlDbType.VarChar, price),
                DataAccessLayer.CreateParameter("@QuotSpecification", SqlDbType.VarChar, specific));
            DataAccessLayer.Close();
            return i;
        }
    }
}
