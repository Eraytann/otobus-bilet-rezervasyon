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
using System.IO;

namespace Otobus
{
    public partial class ClubCardUyelik : Form
    {

        string resimyolu;
        public ClubCardUyelik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void lblUyeNo_Click(object sender, EventArgs e)
        {

        }

        private void ClubCardUyelik_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            kart_uyelik frm_kart_uyelik = new kart_uyelik();
            frm_kart_uyelik.TopLevel = false;
            panel_orta.Controls.Add(frm_kart_uyelik);
            frm_kart_uyelik.Show();
            frm_kart_uyelik.Dock = DockStyle.None;
            frm_kart_uyelik.BringToFront();
        }

        private void panel_orta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTelefon.Text.Length == 11)
            {
                e.Handled = true;
            }

            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                resimyolu = ofd.FileName;
                pictureBox1.ImageLocation = resimyolu;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTelefon.Text == "" || cBoxSure.Text == "")
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
                cmd.CommandText = "INSERT INTO ClubCardBilgileri(Adi,Soyadi,Telefon,Cinsiyet,UyelikSuresi,Resim) VALUES(@Adi,@Soyadi,@Telefon,@Cinsiyet,@UyelikSuresi,@Resim)";

                //Parametreleri Oluştur
                cmd.Parameters.Add("@Adi", OleDbType.VarChar);
                cmd.Parameters["@Adi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Adi"].Value = txtAd.Text;
                cmd.Parameters.Add("@Soyadi", OleDbType.VarChar);
                cmd.Parameters["@Soyadi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Soyadi"].Value = txtSoyad.Text;
                cmd.Parameters.Add("@Telefon", OleDbType.VarChar);
                cmd.Parameters["@Telefon"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Telefon"].Value = txtTelefon.Text;
                cmd.Parameters.Add("@Resim", OleDbType.VarChar);
                cmd.Parameters["@Resim"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Resim"].Value = resimyolu;

                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.Add("@Cinsiyet", OleDbType.VarChar);
                    cmd.Parameters["@Cinsiyet"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@Cinsiyet"].Value = radioButton1.Text;
                }
                if (radioButton2.Checked == true)
                {
                    cmd.Parameters.Add("@Cinsiyet", OleDbType.VarChar);
                    cmd.Parameters["@Cinsiyet"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@Cinsiyet"].Value =radioButton2.Text;
                }

                cmd.Parameters.Add("@UyelikSuresi", OleDbType.VarChar);
                cmd.Parameters["@UyelikSuresi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@UyelikSuresi"].Value = cBoxSure.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTelefon.Text = "";
                    cBoxSure.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    pictureBox1.Image = ımageList1.Images[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

                //Bağlantıyı Kapat
                con.Close();
            }
        }

        private void cBoxSure_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
