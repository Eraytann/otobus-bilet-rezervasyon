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
    public partial class BiletIslem : Form
    {
        public BiletIslem()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            Biletİptali frm_Biletİptali = new Biletİptali();
            frm_Biletİptali.TopLevel = false;
            panel_orta.Controls.Add(frm_Biletİptali);
            frm_Biletİptali.Show();
            frm_Biletİptali.Dock = DockStyle.None;
            frm_Biletİptali.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*panel_orta.Controls.Clear();//formun içini temizliyoruz..
            BiletAl frm_BiletAl = new BiletAl();
            frm_BiletAl.TopLevel = false;
            panel_orta.Controls.Add(frm_BiletAl);
            frm_BiletAl.Show();
            frm_BiletAl.Dock = DockStyle.None;
            frm_BiletAl.BringToFront();*/

            panel_orta.Controls.Clear();//formun içini temizliyoruz..
            BiletAl frm_BiletAl = new BiletAl();
            frm_BiletAl.TopLevel = false;
            panel_orta.Controls.Add(frm_BiletAl);
            frm_BiletAl.Show();
            frm_BiletAl.Dock = DockStyle.None;
            frm_BiletAl.BringToFront(); 

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
