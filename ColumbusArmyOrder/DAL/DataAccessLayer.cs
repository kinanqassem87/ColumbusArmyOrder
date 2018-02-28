using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ColumbusArmyOrder.Pl;

namespace ColumbusArmyOrder.DAL
{
    
    class DataAccessLayer
    {
        //Server=Admin; /Or Server=192.168.1.99;
        //public static string con = "Server= Admin; Database= ColumbusOrder; Integrated Security=True;";
        public static string con = "Server= 192.168.1.99; Database= ColumbusOrder;User ID=sa ;Password=123;Pooling=false;";



        public static SqlConnection cn;
        //open the connection 
        public static void Open()
        {
                cn = new SqlConnection(con);
                cn.Open();
            
        }
        //close the connection 
        public static void Close()
        {
           
                cn = new SqlConnection(con);
                cn.Close();
                //cn.Dispose();
              //  SqlConnection.ClearPool(cn);
            
        }
        //return one value
        public static object ExcuteScalar(string query, CommandType type, params SqlParameter[] arr)
        {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddRange(arr);
                cmd.CommandType = type;
                object o = cmd.ExecuteScalar();
                return o;
            
        }
        //delete,Update,insert return number of effect rows
        public static int ExecuteNonQuery(string query, CommandType type, params SqlParameter[] arr)
        {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = type;
                cmd.Parameters.AddRange(arr);
                int n = cmd.ExecuteNonQuery();
                return n;
          
        }
        //return table
        public static DataTable ExecuteTable(string query, CommandType type, params SqlParameter[] arr)
        {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = type;
                cmd.Parameters.AddRange(arr);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
        }
        //create parameter to use above function return parameter
        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;
        }
    }
}

