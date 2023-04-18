namespace Otobus
{
    partial class Otobusler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otobusler));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_orta = new System.Windows.Forms.Panel();
            this.baslik = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtModel = new System.Windows.Forms.ComboBox();
            this.txtPlaka = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxTipi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.panel_orta.SuspendLayout();
            this.baslik.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_orta
            // 
            this.panel_orta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_orta.Controls.Add(this.btnKaydet);
            this.panel_orta.Controls.Add(this.baslik);
            this.panel_orta.Controls.Add(this.groupBox2);
            this.panel_orta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_orta.Location = new System.Drawing.Point(0, 0);
            this.panel_orta.Name = "panel_orta";
            this.panel_orta.Size = new System.Drawing.Size(805, 545);
            this.panel_orta.TabIndex = 0;
            this.panel_orta.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_orta_Paint);
            // 
            // baslik
            // 
            this.baslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(65)))), ((int)(((byte)(108)))));
            this.baslik.Controls.Add(this.pictureBox4);
            this.baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.baslik.Location = new System.Drawing.Point(0, 0);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(805, 58);
            this.baslik.TabIndex = 202;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKoltukSayisi);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtPlaka);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cBoxTipi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox2.Location = new System.Drawing.Point(151, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 235);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rota Bilgileri";
            // 
            // txtModel
            // 
            this.txtModel.FormattingEnabled = true;
            this.txtModel.Items.AddRange(new object[] {
            "Travego",
            "Setra",
            "Man",
            "Neonplan",
            "Tourismo"});
            this.txtModel.Location = new System.Drawing.Point(117, 83);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(157, 29);
            this.txtModel.TabIndex = 205;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(117, 35);
            this.txtPlaka.Mask = "00-LLL-00";
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(157, 27);
            this.txtPlaka.TabIndex = 204;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Koltuk Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modeli:";
            // 
            // cBoxTipi
            // 
            this.cBoxTipi.FormattingEnabled = true;
            this.cBoxTipi.Items.AddRange(new object[] {
            "2+2",
            "2+1"});
            this.cBoxTipi.Location = new System.Drawing.Point(117, 133);
            this.cBoxTipi.Name = "cBoxTipi";
            this.cBoxTipi.Size = new System.Drawing.Size(157, 29);
            this.cBoxTipi.TabIndex = 15;
            this.cBoxTipi.SelectedIndexChanged += new System.EventHandler(this.cBoxTipi_SelectedIndexChanged);
            this.cBoxTipi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBoxTipi_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Koltuk Tipi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Plaka:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.BorderRadius = 0;
            this.btnKaydet.ButtonText = "Otobüsü Ekle";
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKaydet.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Iconimage")));
            this.btnKaydet.Iconimage_right = null;
            this.btnKaydet.Iconimage_right_Selected = null;
            this.btnKaydet.Iconimage_Selected = null;
            this.btnKaydet.IconZoom = 35D;
            this.btnKaydet.IsTab = false;
            this.btnKaydet.Location = new System.Drawing.Point(311, 377);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnKaydet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(147, 48);
            this.btnKaydet.TabIndex = 203;
            this.btnKaydet.Textcolor = System.Drawing.Color.White;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 198;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(117, 188);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(157, 27);
            this.txtKoltukSayisi.TabIndex = 206;
            // 
            // Otobusler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 545);
            this.Controls.Add(this.panel_orta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Otobusler";
            this.Text = "Otobusler";
            this.Load += new System.EventHandler(this.Otobusler_Load);
            this.panel_orta.ResumeLayout(false);
            this.baslik.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_orta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBoxTipi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel baslik;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private System.Windows.Forms.MaskedTextBox txtPlaka;
        private System.Windows.Forms.ComboBox txtModel;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
    }
}