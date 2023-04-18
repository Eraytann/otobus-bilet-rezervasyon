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
    public partial class Biletİptali : Form
    {
        public Biletİptali()
        {
            InitializeComponent();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            if (txtMusteriNo.Text == "")
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
                cmd.CommandText = "DELETE FROM YolcuBilgileri WHERE MusteriNo=@MusteriNo";

                //Parametre
                cmd.Parameters.Add("@MusteriNo", OleDbType.Char);
                cmd.Parameters["@MusteriNo"].Direction = ParameterDirection.Input;
                cmd.Parameters["@MusteriNo"].Value = txtMusteriNo.Text;

                if (MessageBox.Show("Bu Kaydı silmek istediğinizden emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        this.Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata:" + ex.Message);
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            BiletIslem frm_BiletIslem = new BiletIslem();
            frm_BiletIslem.TopLevel = false;
            panel_orta.Controls.Add(frm_BiletIslem);
            frm_BiletIslem.Show();
            frm_BiletIslem.Dock = DockStyle.None;
            frm_BiletIslem.BringToFront();
        }

        private void Biletİptali_Load(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtobusVeritabani"].ConnectionString;
            con.Open();

            //Komut Nesnesi Oluştur
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM YolcuBilgileri";

            //DataAdapter
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //Dataset Oluştur
            DataSet ds = new DataSet();

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                da.Fill(ds, "YolcuBilgileri");
                dataGridView1.DataSource = ds.Tables["YolcuBilgileri"];
            }
            dr.Close();
            con.Close();
        }
    }
}
