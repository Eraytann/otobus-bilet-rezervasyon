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
    public partial class BiletForm : Form
    {
        public BiletForm()
        {
            InitializeComponent();
        }

        PictureBox[] koltuk = new PictureBox[40];
        int koltuksecim, eskikoltuk;
        string koltukno = "";
        private void BiletForm_Load(object sender, EventArgs e)
        {
            dtpSaat.Format = DateTimePickerFormat.Custom;
            dtpSaat.CustomFormat = "hh:mm:ss";
            int[] dizibosdolu = new int[40];
            lblSeferNo.Text = BiletAl.SeferNo.ToString();
            lblPlaka.Text = BiletAl.Plaka.ToString();
            dtpTarih.MinDate = DateTime.Now.Date;
            koltukyukle();
            pbox_bosyukle();
    
        }

            private void koltukyukle()
            {
                int x = 125;
                int y = 348;
                for (int i = 0; i < 40; i++)
                {
                    if (i > 1 && i % 10 == 0) // her 10 pb da 1 alt satıra inme 
                    {
                        if (i > 1 && i % 20 == 0)//her 20 pbı ,satır 25px artsın
                        {
                            y += 25;
                            x = 0;
                        }
                        y += 40; // pb ı alt satıra indirme
                        x = 125;  // pb ı en sağa aldık
                    }
                    /*
                    int x = 125;
                    int y = 348;
                    for (int i = 0; i < 40; i++)
                    {
                        if (i > 0 && i % 1 == 0) // her 10 pb da 1 alt satıra inme 
                        {
                            x = 125;
                            if (i > 0 && i % 2 == 0)
                            {
                                y += 25;
                                x = 125;
                                if (i % 4 == 0)
                                {
                                    y = 308;
                                    x = 178;
                                }

                            }
                            y += 40;
                    }*/
                    x += 45;    // pb ı sağa kaydırdık
                    koltuk[i] = new PictureBox();
                    koltuk[i].Location = new Point(x, y);     // pb ı form üzerinde konumlandırma
                    koltuk[i].Size = new Size(42, 26);       //  pb ın boyutu ayarlama
                    koltuk[i].Click += new EventHandler(tikla);  // pb a click özelliği kazandırma
                    koltuk[i].Tag = i;                           // hangi pb a tıklanıldığını öğrenmek için
                    koltuk[i].BringToFront();
                    panel_orta.Controls.Add(koltuk[i]);                // pb a form üzerine ekleme
                }
            }
            private void pbox_bosyukle()    // dinamik olarak oluşturulan pb dizisine boş resimler yükleme
            {
                for (int i = 0; i < 40; i++)
                {
                    koltuk[i].Image = ımageList1.Images[0];
                }
            }
            private void tikla(object sender, EventArgs y)
            {
                if (radioButton1.Checked == true)
                {
                    koltuk[eskikoltuk].Image = ımageList1.Images[0];
                    koltuksecim = Convert.ToInt16(((PictureBox)sender).Tag);
                    koltuk[koltuksecim].Image = ımageList1.Images[5];
                    koltukno = koltuk[koltuksecim].Tag.ToString();
                    txtKoltukNo.Text = Convert.ToString(Convert.ToInt32(koltukno) + 1);
                    eskikoltuk = koltuksecim;
                }
                else if (radioButton2.Checked == true)
                {
                    koltuk[eskikoltuk].Image = ımageList1.Images[0];
                    koltuksecim = Convert.ToInt16(((PictureBox)sender).Tag);
                    koltuk[koltuksecim].Image = ımageList1.Images[6];
                    koltukno = koltuk[koltuksecim].Tag.ToString();
                    txtKoltukNo.Text = Convert.ToString(Convert.ToInt32(koltukno) + 1);
                    eskikoltuk = koltuksecim;
                }
                else
                {
                    MessageBox.Show("Lütfen Cinsiyet Seçin", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }


            }
            private void listele()
            {
                //connection
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtobusVeritabani"].ConnectionString;
                con.Open();

                //command
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM YolcuBilgileri";
            }
            private void button1_Click(object sender, EventArgs e)
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

            private void button1_Click_1(object sender, EventArgs e)
            {

            }

            private void pictureBox4_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void panel_orta_Paint(object sender, PaintEventArgs e)
            {

            }

            private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
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

            private void cBoxNerden_KeyPress(object sender, KeyPressEventArgs e)
            {

            }

            private void cBoxNereye_KeyPress(object sender, KeyPressEventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {

            }

            private void dtpTarih_ValueChanged(object sender, EventArgs e)
            {

            }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Connection Oluştur
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtobusVeritabani"].ConnectionString;
            con.Open();

            //Komut Nesnesi Oluştur
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO YolcuBilgileri(Adi,Soyadi,Telefon,Cinsiyet,ClubCard,KoltukNo,Tarih,KimlikNu) VALUES(@Adi,@Soyadi,@Telefon,@Cinsiyet,@ClubCard,@KoltukNo,@Tarih,@KimlikNu)";

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
            cmd.Parameters.Add("@KoltukNo", OleDbType.VarChar);
            cmd.Parameters["@KoltukNo"].Direction = ParameterDirection.Input;
            cmd.Parameters["@KoltukNo"].Value = txtKoltukNo.Text;
            cmd.Parameters.Add("@Tarih", OleDbType.VarChar);
            cmd.Parameters["@Tarih"].Direction = ParameterDirection.Input;
            cmd.Parameters["@Tarih"].Value = dtpTarih.Text;
            cmd.Parameters.Add("@SeferNo", OleDbType.VarChar);
            cmd.Parameters["@SeferNo"].Direction = ParameterDirection.Input;
            cmd.Parameters["@SeferNo"].Value = lblSeferNo.Text;
            cmd.Parameters.Add("@Plaka", OleDbType.VarChar);
            cmd.Parameters["@Plaka"].Direction = ParameterDirection.Input;
            cmd.Parameters["@Plaka"].Value = lblPlaka.Text;
            cmd.Parameters.Add("@KimlikNu", OleDbType.VarChar);
            cmd.Parameters["@KimlikNu"].Direction = ParameterDirection.Input;
            cmd.Parameters["@KimlikNu"].Value = txtKimlikNu.Text;
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
                cmd.Parameters["@Cinsiyet"].Value = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                cmd.Parameters.Add("@ClubCard", OleDbType.VarChar);
                cmd.Parameters["@ClubCard"].Direction = ParameterDirection.Input;
                cmd.Parameters["@ClubCard"].Value = radioButton3.Text;
            }
            if (radioButton4.Checked == true)
            {
                cmd.Parameters.Add("@ClubCard", OleDbType.VarChar);
                cmd.Parameters["@ClubCard"].Direction = ParameterDirection.Input;
                cmd.Parameters["@ClubCard"].Value = radioButton4.Text;
            }
            try
            {
                cmd.ExecuteNonQuery();
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTelefon.Text = "";
                txtKoltukNo.Text = "";
                txtTelefon.Text = "";
                lblSeferNo.Text = "";
                lblPlaka.Text = "";
                lblUcret.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            con.Close();


            OleDbConnection con1 = new OleDbConnection();
            con1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtobusVeritabani"].ConnectionString;
            con1.Open();

            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.Connection = con1;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "INSERT INTO BiletSatislari(SeferNo,KoltukNo,Ucret,Tarih,Plaka,Saat,KimlikNu) VALUES(@SeferNo,@KoltukNo,@Ucret,@Tarih,@Plaka,@Saat,@KimlikNu)";

            cmd1.Parameters.Add("@SeferNo", OleDbType.VarChar);
            cmd1.Parameters["@SeferNo"].Direction = ParameterDirection.Input;
            cmd1.Parameters["@SeferNo"].Value = lblSeferNo.Text;
            cmd1.Parameters.Add("@KoltukNo", OleDbType.VarChar);
            cmd1.Parameters["@KoltukNo"].Direction = ParameterDirection.Input;
            cmd1.Parameters["@KoltukNo"].Value = txtKoltukNo.Text;
            cmd1.Parameters.Add("@Ucret", OleDbType.VarChar);
            cmd1.Parameters["@Ucret"].Direction = ParameterDirection.Input;
            cmd1.Parameters["@Ucret"].Value = lblUcret.Text;
            cmd1.Parameters.Add("@Tarih", OleDbType.VarChar);
            cmd1.Parameters["@Tarih"].Direction = ParameterDirection.Input;
            cmd1.Parameters["@Tarih"].Value = dtpTarih.Text;
            cmd1.Parameters.Add("@Plaka", OleDbType.VarChar);
            cmd1.Parameters["@Plaka"].Direction = ParameterDirection.Input;
            cmd1.Parameters["@Plaka"].Value = lblPlaka.Text;
            cmd.Parameters.Add("@Saat", OleDbType.VarChar);
            cmd.Parameters["@Saat"].Direction = ParameterDirection.Input;
            cmd.Parameters["@Saat"].Value = dtpSaat.Text;
            cmd.Parameters.Add("@KimlikNu", OleDbType.VarChar);
            cmd.Parameters["@KimlikNu"].Direction = ParameterDirection.Input;
            cmd.Parameters["@KimlikNu"].Value = txtKimlikNu.Text;
            try
            {
                cmd1.ExecuteNonQuery();
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTelefon.Text = "";
                txtKoltukNo.Text = "";
                txtTelefon.Text = "";
                lblSeferNo.Text = "";
                lblPlaka.Text = "";
                lblUcret.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            //Bağlantıyı Kapat
    
            con1.Close();

        }
            private void dtpTarih_ValueChanged_1(object sender, EventArgs e)
            {

            }

            private void button2_Click_1(object sender, EventArgs e)
            {

            }
        }
    } 



