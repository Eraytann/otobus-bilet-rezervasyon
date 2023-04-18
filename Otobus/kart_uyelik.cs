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
    public partial class kart_uyelik : Form
    {
        public kart_uyelik()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            ClubCardUyelik frm_ClubCardUyelik = new ClubCardUyelik();
            frm_ClubCardUyelik.TopLevel = false;
            panel_orta.Controls.Add(frm_ClubCardUyelik);
            frm_ClubCardUyelik.Show();
            frm_ClubCardUyelik.Dock = DockStyle.None;
            frm_ClubCardUyelik.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            ClubCardDuzenleme frm_ClubCardDuzenleme = new ClubCardDuzenleme();
            frm_ClubCardDuzenleme.TopLevel = false;
            panel_orta.Controls.Add(frm_ClubCardDuzenleme);
            frm_ClubCardDuzenleme.Show();
            frm_ClubCardDuzenleme.Dock = DockStyle.None;
            frm_ClubCardDuzenleme.BringToFront();
        }

        private void baslat_Tick(object sender, EventArgs e)
        {
         
            
        }
    }
}
