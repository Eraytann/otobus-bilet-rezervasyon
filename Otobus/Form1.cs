using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_uyelik_Click(object sender, EventArgs e)
        {
            /*BiletForm frm_BiletForm = new BiletForm();
            frm_BiletForm.Show();*/

            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            kart_uyelik frm_kart_uyelik = new kart_uyelik();
            frm_kart_uyelik.TopLevel = false;
            panel_orta.Controls.Add(frm_kart_uyelik);
            frm_kart_uyelik.Show();
            frm_kart_uyelik.Dock = DockStyle.None;
            frm_kart_uyelik.BringToFront();

     
        }

        private void btn_bilet_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            BiletIslem frm_BiletIslem = new BiletIslem();
            frm_BiletIslem.TopLevel = false;
            panel_orta.Controls.Add(frm_BiletIslem);
            frm_BiletIslem.Show();
            frm_BiletIslem.Dock = DockStyle.None;
            frm_BiletIslem.BringToFront();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baslik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            Personel frm_Personel = new Personel();
            frm_Personel.TopLevel = false;
            panel_orta.Controls.Add(frm_Personel);
            frm_Personel.Show();
            frm_Personel.Dock = DockStyle.None;
            frm_Personel.BringToFront();
        }

        private void btnSefer_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            Seferler frm_seferler = new Seferler();
            frm_seferler.TopLevel = false;
            panel_orta.Controls.Add(frm_seferler);
            frm_seferler.Show();
            frm_seferler.Dock = DockStyle.None;
            frm_seferler.BringToFront();
        }

        private void btnOtobus_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            Otobusler frm_otobus = new Otobusler();
            frm_otobus.TopLevel = false;
            panel_orta.Controls.Add(frm_otobus);
            frm_otobus.Show();
            frm_otobus.Dock = DockStyle.None;
            frm_otobus.BringToFront();
        }

        private void panel_orta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


