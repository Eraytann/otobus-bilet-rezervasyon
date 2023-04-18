using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otobus
{
    public partial class SeferIptali : Form
    {
        public SeferIptali()
        {
            InitializeComponent();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            if (txtSeferNo.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurun", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                //connection
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtobusVeritabani"].ConnectionString;
                con.Open();

                //command
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Seferler WHERE SeferNo=@SeferNo";


                //Parametreleri Oluştur
                cmd.Parameters.Add("@SeferNo", OleDbType.VarChar);
                cmd.Parameters["@SeferNo"].Direction = ParameterDirection.Input;
                cmd.Parameters["@SeferNo"].Value = txtSeferNo.Text;
                if (MessageBox.Show("Bu Kaydı silmek istediğinizden emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        this.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
                //Bağlantıyı Kapat
                con.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            Seferler frm_Seferler = new Seferler();
            frm_Seferler.TopLevel = false;
            panel_orta.Controls.Add(frm_Seferler);
            frm_Seferler.Show();
            frm_Seferler.Dock = DockStyle.None;
            frm_Seferler.BringToFront();
        }
    }
}
