using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivesConverter
{
    public partial class HISTORIC : Form
    {
        public HISTORIC()
        {
            InitializeComponent();
            TABLE_ARCHIVES.DataSource = SEARCH_ARCHIVES();
        }

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");

        public DataTable SEARCH_ARCHIVES()
        {
            SqlCeDataAdapter SERACH_PRODUCTS = new SqlCeDataAdapter("SELECT Arquivo, De, Para, Destino, Date FROM historic ORDER By id DESC", con);

            DataSet SP = new DataSet();

            SERACH_PRODUCTS.Fill(SP);

            return SP.Tables[0];
        }

        private void TABLE_PRODUTOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TABLE_ARCHIVES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TABLE_ARCHIVES_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string caminho = "";
            string formato = "";
            string nome_arquivo = "";

            if (Convert.ToInt32(TABLE_ARCHIVES.RowCount.ToString()) >= 1)
            {

                DataGridViewRow linhaAtual = TABLE_ARCHIVES.CurrentRow;

                caminho = Convert.ToString((linhaAtual.Cells[3]).Value);
                formato = Convert.ToString((linhaAtual.Cells[2]).Value);
                nome_arquivo = Convert.ToString((linhaAtual.Cells[0]).Value);

                string caminho_completed = caminho + nome_arquivo + formato;

                if (MessageBox.Show("Deseja abrir este arquivo? \n\n'" + nome_arquivo + formato + "'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(caminho_completed);
                    }
                    catch
                    {
                        MessageBox.Show("Ops, não foi possível encontrar este arquivo!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Ops, não foi possível encontrar este arquivo!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
