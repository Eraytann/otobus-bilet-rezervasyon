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
    public partial class Otobusler : Form
    {
        public Otobusler()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtModel.Text == "" || txtPlaka.Text == "" || txtKoltukSayisi.Text == "" || cBoxTipi.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurun", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                //Connection Oluştur
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtobusVeritabani"].ConnectionString;
                con.Open();

                //Komut Nesnesi Oluştur
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO OtobusBilgileri(Plaka,Modeli,KoltukSayisi,Turu) VALUES(@Plaka,@Modeli,@KoltukSayisi,@Turu)";

                //Parametreleri Oluştur
                cmd.Parameters.Add("@Plaka", OleDbType.VarChar);
                cmd.Parameters["@Plaka"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Plaka"].Value = txtPlaka.Text;
                cmd.Parameters.Add("@Modeli", OleDbType.VarChar);
                cmd.Parameters["@Modeli"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Modeli"].Value = txtModel.Text;
                cmd.Parameters.Add("@KoltukSayisi", OleDbType.VarChar);
                cmd.Parameters["@KoltukSayisi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@KoltukSayisi"].Value = txtKoltukSayisi.Text;
                cmd.Parameters.Add("@Turu", OleDbType.VarChar);
                cmd.Parameters["@Turu"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Turu"].Value = cBoxTipi.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    txtModel.Text = "";
                    txtPlaka.Text = "";
                    txtKoltukSayisi.Text = "";
                    cBoxTipi.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                //Bağlantıyı Kapat
                con.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            Form1 frm_Form1 = new Form1();
            frm_Form1.TopLevel = false;
            frm_Form1.Show();
            frm_Form1.Dock = DockStyle.None;
            frm_Form1.BringToFront();
        }

        private void cBoxKoltuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cBoxTipi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cBoxTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxTipi.SelectedIndex==0)
            {
                txtKoltukSayisi.Text = "40";
            }
            else
            {
                txtKoltukSayisi.Text = "30";
            }
        }

        private void panel_orta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Otobusler_Load(object sender, EventArgs e)
        {
            txtKoltukSayisi.Enabled = false;
        }
    }
}
