using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColumbusArmyOrder.BL
{
    class Learn
    {
    }
}
/* we need import
 * using ColumbusArmyOrder.DAL;
 * 
 * 
 * insert,update,delete
 * public static int SP_ADDNEWCATOGARY(string cat_name)
        {
            DataAccessLayer.Open();
         int count=DataAccessLayer.ExecuteNonQuery("SP_ADDNEWCATOGARY", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CATOGARY_NAME", SqlDbType.VarChar, cat_name));
         DataAccessLayer.Close();
         return count;
        }
 * 
 * select,search
        public static DataTable SP_SELECTALLCATEGORIES()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTALLCATEGORIES", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
 * */
