using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace Otobus
{
    public partial class ClubCardDuzenleme : Form
    {

        string resimyolu = "";

        public ClubCardDuzenleme()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTelefon.Text == "")
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
                cmd.CommandText = "UPDATE clubcardbilgileri SET adi=@Adi,soyadi=@Soyadi,telefon=@Telefon,resim=@Resim WHERE UyeNo=@UyeNo";

                //parametreler
                cmd.Parameters.Add("@Adi", OleDbType.VarChar);
                cmd.Parameters["@Adi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@adi"].Value = txtAd.Text;
                cmd.Parameters.Add("@Soyadi", OleDbType.VarChar);
                cmd.Parameters["@Soyadi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Soyadi"].Value = txtSoyad.Text;
                cmd.Parameters.Add("@Telefon", OleDbType.VarChar);
                cmd.Parameters["@Telefon"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Telefon"].Value = txtTelefon.Text;
                cmd.Parameters.Add("@Resim", OleDbType.VarChar);
                cmd.Parameters["@Resim"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Resim"].Value = resimyolu;
                cmd.Parameters.Add("@UyeNo", OleDbType.VarChar);
                cmd.Parameters["@UyeNo"].Direction = ParameterDirection.Input;
                cmd.Parameters["@UyeNo"].Value = lblUyeNo.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTelefon.Text = "";
                    txtUyeNo.Text = "";
                    lblUyeNo.Text = "";
                    pictureBox1.Image = ımageList1.Images[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata:" + ex.Message);
                }
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //connection
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtobusVeritabani"].ConnectionString;
            con.Open();

            //command
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ClubCardBilgileri WHERE UyeNo=@UyeNo";
            cmd.Parameters.Add("@UyeNo", OleDbType.Char);
            cmd.Parameters["@UyeNo"].Direction = ParameterDirection.Input;
            cmd.Parameters["@UyeNo"].Value = txtUyeNo.Text;

            //datareader
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                lblUyeNo.Text = dr["UyeNo"].ToString();
                txtAd.Text = dr["Adi"].ToString();
                txtSoyad.Text = dr["Soyadi"].ToString();
                txtTelefon.Text = dr["Telefon"].ToString();
                pictureBox1.ImageLocation=dr["Resim"].ToString();
            }
            else
            {
                MessageBox.Show("Aradığınız Kayıt Bulunamadı.");
            }

            //connection kapat
            con.Close();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTelefon.Text == "")
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
                cmd.CommandText = "DELETE FROM ClubCardBilgileri WHERE UyeNo=@UyeNo";

                //Parametre
                cmd.Parameters.Add("@UyeNo", OleDbType.Char);
                cmd.Parameters["@UyeNo"].Direction = ParameterDirection.Input;
                cmd.Parameters["@UyeNo"].Value = txtUyeNo.Text;
                if (MessageBox.Show("Bu Kaydı silmek istediğinizden emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        txtUyeNo.Text = "";
                        txtAd.Text = " ";
                        txtSoyad.Text = "";
                        txtTelefon.Text = "";
                        pictureBox1.Image = ımageList1.Images[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata:" + ex.Message);
                    }
                }

                con.Close();
            }
        }
        private void ClubCardDuzenleme_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtUyeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtUyeNo.Text = "";
            lblUyeNo.Text = "";
            pictureBox1.Image = ımageList1.Images[0];
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

        private void baslik_Paint(object sender, PaintEventArgs e)
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtUyeNo.Text == "")
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
                cmd.CommandText = "SELECT * FROM Clubcardbilgileri WHERE UyeNo=@UyeNo";
                cmd.Parameters.Add("@UyeNo", OleDbType.Char);
                cmd.Parameters["@UyeNo"].Direction = ParameterDirection.Input;
                cmd.Parameters["@UyeNo"].Value = txtUyeNo.Text;

                //datareader
                OleDbDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    lblUyeNo.Text = dr["UyeNo"].ToString();
                    txtAd.Text = dr["Adi"].ToString();
                    txtSoyad.Text = dr["Soyadi"].ToString();
                    txtTelefon.Text = dr["Telefon"].ToString();
                    pictureBox1.ImageLocation = dr["Resim"].ToString();
                }
                else
                {
                    MessageBox.Show("Aradığınız Kayıt Bulunamadı.");
                }

                //connection kapat
                con.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
          
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                resimyolu = ofd.FileName;
                pictureBox1.ImageLocation = resimyolu;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
   
