using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace TPDisenio2014
{
    class SQL_Methods //Clase Abstracta (No se va a instanciar)
    {
        #region Variables de Clase
        public static bool DBConnectStatus = false;
        #endregion

        static public SqlConnection IniciarConnection()
        {
            SqlConnection myConnection;
            string ConectionQuery = "MATIAS-HP\SQLSERVER2008;Initial Catalog=disenio_tp;Integrated Security=True";

            myConnection = new SqlConnection(ConectionQuery);
            try
            {
                myConnection.Open();
                DBConnectStatus = true;
                return myConnection;
            }
            catch (Exception e)
            {
                DBConnectStatus = false;
                MessageBox.Show(ConectionQuery);
                MessageBox.Show(e.ToString());
                return null;
            }
        }


         static public DataTable EjecutarProcedure(SqlConnection myConnection, string myQuery)
        {
            SqlDataAdapter miDataAdapter;
            DataSet miDataSet;
            DataTable unaDataTable = new DataTable();

            miDataAdapter = new SqlDataAdapter(myQuery, myConnection);
            miDataSet = new DataSet();
            miDataAdapter.Fill(miDataSet, "Tabla");
            unaDataTable = miDataSet.Tables["Tabla"];
            miDataSet.Dispose();
            miDataAdapter.Dispose();
            
            return unaDataTable;
        }



    }
}
