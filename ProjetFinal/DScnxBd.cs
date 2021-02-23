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
            cnx = "Data Source= 192.168.43.103\\SQLEXPRESS,1433;Network Library=DBMSSOCN; Initial Catalog =Gestion_Etudiant;Integrated Security = true";
            conn = new SqlConnection(cnx);
            conn.Open();
            adapter2 = new SqlDataAdapter("SELECT * FROM filliere", conn);
            adapter2.Fill(ds, "filliere");
            adapter4 = new SqlDataAdapter("SELECT * FROM etudiant", conn);
            conn.Close();
            adapter4.Fill(ds, "etudiant");

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

