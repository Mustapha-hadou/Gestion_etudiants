using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetFinal
{
    class DScnxBd
    {
        private string cnx;
        private static SqlConnection conn;
        private static SqlDataAdapter adapter2;
        private static SqlDataAdapter adapter4;

        public static DataSet ds = new DataSet();

        public DScnxBd()
        {
            conn = new SqlConnection(getConnection());
            conn.Open();
            adapter2 = new SqlDataAdapter("SELECT * FROM filliere", conn);
            adapter2.Fill(ds, "filliere");
            adapter4 = new SqlDataAdapter("SELECT * FROM etudiant", conn);
            conn.Close();
            adapter4.Fill(ds, "etudiant");

        }
        public static string getConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "gestion-etud.database.windows.net";
            builder.UserID = "ge";
            builder.Password = "123hadouM";
            builder.InitialCatalog = "Gestion_Etudiants";
            return builder.ConnectionString;
        }
        public static Boolean verifierExitanceCNE(String cne)
        {
            Console.WriteLine(DScnxBd.ds.Tables["etudiant"].Rows.Count);
            for (int i = 0; i < DScnxBd.ds.Tables["etudiant"].Rows.Count; i++)
            {
                if (!(DScnxBd.ds.Tables["etudiant"].Rows[i].RowState == DataRowState.Deleted))
                {
                    if (cne.Equals(DScnxBd.ds.Tables["etudiant"].Rows[i][0].ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void updateBD()
        {
            conn.Open();
            SqlCommandBuilder cmdBuilder1 = new SqlCommandBuilder(adapter2);
            SqlCommandBuilder cmdBuilder2 = new SqlCommandBuilder(adapter4);
            adapter2.Update(ds.Tables["filliere"]);
            adapter4.Update(ds.Tables["etudiant"]);
            conn.Close();

        }

    }


}

