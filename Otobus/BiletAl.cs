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
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }

        public static string SeferNo="";
        public static string Plaka = "";
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int a = 0;
            dataGridView1.Rows.Clear();
            //Connection Oluştur
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtobusVeritabani"].ConnectionString;
            con.Open();

            //Komut Nesnesi Oluştur
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Seferler WHERE Tarih=@Tarih AND Nerden=@Nerden AND Nereye=@Nereye";

            //Parametreleri Oluştur
            cmd.Parameters.Add("@Tarih", OleDbType.VarChar);
            cmd.Parameters["@Tarih"].Direction = ParameterDirection.Input;
            cmd.Parameters["@Tarih"].Value = Tarih.Text;
            cmd.Parameters.Add("@Nerden", OleDbType.VarChar);
            cmd.Parameters["@Nerden"].Direction = ParameterDirection.Input;
            cmd.Parameters["@Nerden"].Value = cBoxNerden.Text;
            cmd.Parameters.Add("@Nereye", OleDbType.VarChar);
            cmd.Parameters["@Nereye"].Direction = ParameterDirection.Input;
            cmd.Parameters["@Nereye"].Value = cBoxNereye.Text;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[a].Cells[0].Value = dr["SeferNo"].ToString();
                dataGridView1.Rows[a].Cells[1].Value = dr["Plaka"].ToString();
                dataGridView1.Rows[a].Cells[2].Value = dr["Nerden"].ToString();
                dataGridView1.Rows[a].Cells[3].Value = dr["Nereye"].ToString();
                dataGridView1.Rows[a].Cells[4].Value = dr["KalkisSaati"].ToString();
                dataGridView1.Rows[a].Cells[5].Value = dr["Tarih"].ToString();
                a++;
            }
            /*  else
              {
                  MessageBox.Show("Sefer Bulunamadı!");
              }
              //Bağlantıyı Kapat*/
            con.Close();
        }

        private void panel_orta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BiletAl_Load(object sender, EventArgs e)
        {
            
            //Connection Oluştur
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OtobusVeritabani"].ConnectionString;
            con.Open();

            //Komut Nesnesi Oluştur
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Guzergah";

            OleDbDataReader dr;
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                cBoxNerden.Items.Add(dr["Guzergah"].ToString());
                cBoxNerden.AutoCompleteCustomSource.Add(dr["Guzergah"].ToString());
                cBoxNereye.Items.Add(dr["Guzergah"].ToString());
                cBoxNereye.AutoCompleteCustomSource.Add(dr["Guzergah"].ToString());
            }
            con.Close();
        }

        private void listViewSefer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listViewSefer_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }

        private void listViewSefer_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void listViewSefer_ItemActivate(object sender, EventArgs e)
        {
           
        }

        private void Tarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void baslik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_orta_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {/*
            */
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void BiletAl_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            SeferNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Plaka = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            BiletForm frm_biletform = new BiletForm();
            frm_biletform.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
