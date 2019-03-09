using ConsoleApp3.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Class
{
    class BDDExecADO : IBDDExec
    {
        public string execReq(string req)
        {
            string strConnexion = @"Data Source=DESKTOP-TH99993\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=exerciceLocation";
            StringBuilder buildStr = new StringBuilder();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(strConnexion))
                {
                    SqlCommand sqlCommande = new SqlCommand(req, sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommande.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        for (int i = 0; sqlDataReader.FieldCount > i; i++)
                        {
                            buildStr.Append(sqlDataReader[i]);
                            buildStr.Append(" - ");
                        }
                        buildStr.AppendLine();
                    }
                } //sqlConnection.Close();

            }
            catch (Exception e) { return "Erreur :" + e.Message; }
            return buildStr.ToString();
        }

        public string execReqIUC(string req)
        {
            string strConnexion = @"Data Source=DESKTOP-TH99993\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=exerciceLocation";
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(strConnexion))
                {
                    SqlCommand sqlCommand = new SqlCommand(req, sqlConnection);
                    sqlConnection.Open();
                    int nbRows = sqlCommand.ExecuteNonQuery();
                } //sqlConnection.Close();
            }
            catch (Exception e) { return "Erreur :" + e.Message; }
            return "Success";
        }
    }
}
