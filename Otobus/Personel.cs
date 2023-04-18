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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {

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

        private void panel_orta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd1.Text == "" || txtSoyad1.Text == "" || txtYas1.Text == "" || txtTelefon1.Text == "" || cBoxUnvan1.Text == "")
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
                cmd.CommandText = "UPDATE PersonelBilgileri SET Adi=@Adi,soyadi=@Soyadi,Yas=@Yas,telefon=@Telefon,Unvan=@Unvan WHERE PersonelNo=@PersonelNo";

                //parametreler
                cmd.Parameters.Add("@Adi", OleDbType.Char);
                cmd.Parameters["@Adi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Adi"].Value = txtAd1.Text;
                cmd.Parameters.Add("@Soyadi", OleDbType.VarChar);
                cmd.Parameters["@Soyadi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Soyadi"].Value = txtSoyad1.Text;
                cmd.Parameters.Add("@Yas", OleDbType.VarChar);
                cmd.Parameters["@Yas"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Yas"].Value = txtYas1.Text;
                cmd.Parameters.Add("@Telefon", OleDbType.VarChar);
                cmd.Parameters["@Telefon"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Telefon"].Value = txtTelefon1.Text;
                cmd.Parameters.Add("@Unvan", OleDbType.VarChar);
                cmd.Parameters["@Unvan"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Unvan"].Value = cBoxUnvan1.Text;
                cmd.Parameters.Add("@PersonelNo", OleDbType.Char);
                cmd.Parameters["@PersonelNo"].Direction = ParameterDirection.Input;
                cmd.Parameters["@PersonelNo"].Value = lblPersonelNo.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    txtAd1.Text = "";
                    txtSoyad1.Text = "";
                    txtYas1.Text = "";
                    txtTelefon1.Text = "";
                    cBoxUnvan1.Text = "";
                    txtPersonelNo.Text = "";
                    lblPersonelNo.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata:" + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAd1.Text == "" || txtSoyad1.Text == "" || txtYas1.Text == "" || txtTelefon1.Text == "" || cBoxUnvan1.Text == "")
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
                cmd.CommandText = "DELETE FROM PersonelBilgileri WHERE PersonelNo=@PersonelNo";

                //Parametre
                cmd.Parameters.Add("@PersonelNo", OleDbType.Numeric);
                cmd.Parameters["@PersonelNo"].Direction = ParameterDirection.Input;
                cmd.Parameters["@PersonelNo"].Value = lblPersonelNo.Text;
                if (MessageBox.Show("Bu Kaydı silmek istediğinizden emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        txtAd1.Text = " ";
                        txtSoyad1.Text = "";
                        txtYas1.Text = "";
                        txtTelefon1.Text = "";
                        cBoxUnvan1.Text = "";
                        lblPersonelNo.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata:" + ex.Message);
                    }
                }

                con.Close();
            }

            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtPersonelNo.Text == "")
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
                cmd.CommandText = "SELECT * FROM PersonelBilgileri WHERE PersonelNo=@PersonelNo";
                cmd.Parameters.Add("@PersonelNo", OleDbType.Char);
                cmd.Parameters["@PersonelNo"].Direction = ParameterDirection.Input;
                cmd.Parameters["@PersonelNo"].Value = txtPersonelNo.Text;

                //datareader
                OleDbDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    lblPersonelNo.Text = dr["PersonelNo"].ToString();
                    txtAd1.Text = dr["Adi"].ToString();
                    txtSoyad1.Text = dr["Soyadi"].ToString();
                    txtYas1.Text = dr["Yas"].ToString();
                    txtTelefon1.Text = dr["Telefon"].ToString();
                    cBoxUnvan1.Text = dr["Unvan"].ToString();
                    txtPersonelNo.Text = "";
                }
                else
                {
                    MessageBox.Show("Aradığınız Kayıt Bulunamadı.");
                }

                //connection kapat
                con.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cBoxUnvan.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || txtYas.Text == "" || cBoxUnvan.Text == "")
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
                cmd.CommandText = "INSERT INTO PersonelBilgileri(Adi,Soyadi,Yas,Telefon,Unvan) VALUES(@Adi,@Soyadi,@Yas,@Telefon,@Unvan)";

                //Parametreleri Oluştur
                cmd.Parameters.Add("@Adi", OleDbType.VarChar);
                cmd.Parameters["@Adi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Adi"].Value = txtAd.Text;
                cmd.Parameters.Add("@Soyadi", OleDbType.VarChar);
                cmd.Parameters["@Soyadi"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Soyadi"].Value = txtSoyad.Text;
                cmd.Parameters.Add("@Yas", OleDbType.VarChar);
                cmd.Parameters["@Yas"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Yas"].Value = txtYas.Text;
                cmd.Parameters.Add("@Telefon", OleDbType.VarChar);
                cmd.Parameters["@Telefon"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Telefon"].Value = txtTelefon.Text;
                cmd.Parameters.Add("@Unvan", OleDbType.VarChar);
                cmd.Parameters["@Unvan"].Direction = ParameterDirection.Input;
                cmd.Parameters["@Unvan"].Value = cBoxUnvan.Text;
                try
                {
                    cmd.ExecuteNonQuery();
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtYas.Text = "";
                    txtTelefon.Text = "";
                    cBoxUnvan.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

                //Bağlantıyı Kapat
                con.Close();
            }
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

        private void txtTelefon1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtYas.Text.Length == 2)
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

        private void txtYas1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtYas1.Text.Length == 2)
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

        private void cBoxUnvan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cBoxUnvan1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cBoxUnvan1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtAd1_Validated(object sender, EventArgs e)
        {
 
        }
    }
}
