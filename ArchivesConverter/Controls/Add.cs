using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchivesConverter.Controls;

namespace ArchivesConverter.Controls
{
    class Add
    {

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");

        public static bool NEW_CONVERTER(Variables add)
        {
            con.Close();
            con.Open();
            string INSERT_NEW_HISTORIC = "INSERT INTO [historic] (Arquivo, De, Para, Destino, Date) VALUES (@Arquivo, @De, @Para, @Destino, @Date)";
            SqlCeCommand NEW_HISTORIC = new SqlCeCommand(INSERT_NEW_HISTORIC, con);

            NEW_HISTORIC.Parameters.AddWithValue("@Arquivo", add.ARQUIVO);
            NEW_HISTORIC.Parameters.AddWithValue("@De", add.DE);
            NEW_HISTORIC.Parameters.AddWithValue("@Para", add.Para);
            NEW_HISTORIC.Parameters.AddWithValue("@Destino", add.Destino);
            NEW_HISTORIC.Parameters.AddWithValue("@Date", DateTime.Now.ToLongDateString());

            if (NEW_HISTORIC.ExecuteNonQuery() > 0)
            {
                //MessageBox.Show("Conversão adicionada com sucesso!");
                con.Close();
                return true;
            }
            else
            {
                //MessageBox.Show("Conversão não realizada!");
                con.Close();
                return false;
            }
            con.Close();
            con.Open();
        }

    }
}
