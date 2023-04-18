namespace Otobus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baslik = new System.Windows.Forms.Panel();
            this.header_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_sol = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_orta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ana_panel = new System.Windows.Forms.Panel();
            this.btnOtobus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSefer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPersonel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_bilet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_uyelik = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.baslik.SuspendLayout();
            this.panel_sol.SuspendLayout();
            this.panel_orta.SuspendLayout();
            this.ana_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.baslik.Controls.Add(this.pictureBox3);
            this.baslik.Controls.Add(this.header_label);
            this.baslik.Controls.Add(this.pictureBox1);
            this.baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.baslik.Location = new System.Drawing.Point(0, 0);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(1013, 55);
            this.baslik.TabIndex = 16;
            this.baslik.Paint += new System.Windows.Forms.PaintEventHandler(this.baslik_Paint);
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.header_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.header_label.Location = new System.Drawing.Point(63, 16);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(140, 20);
            this.header_label.TabIndex = 23;
            this.header_label.Text = "Hetro Turizm 2017";
            // 
            // panel_sol
            // 
            this.panel_sol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(65)))), ((int)(((byte)(108)))));
            this.panel_sol.Controls.Add(this.label3);
            this.panel_sol.Controls.Add(this.btnOtobus);
            this.panel_sol.Controls.Add(this.btnSefer);
            this.panel_sol.Controls.Add(this.btnPersonel);
            this.panel_sol.Controls.Add(this.btn_bilet);
            this.panel_sol.Controls.Add(this.btn_uyelik);
            this.panel_sol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sol.Location = new System.Drawing.Point(0, 55);
            this.panel_sol.Name = "panel_sol";
            this.panel_sol.Size = new System.Drawing.Size(211, 558);
            this.panel_sol.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(12, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hetro © 2017";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.baslik;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_orta
            // 
            this.panel_orta.AutoScroll = true;
            this.panel_orta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_orta.Controls.Add(this.label2);
            this.panel_orta.Controls.Add(this.label1);
            this.panel_orta.Location = new System.Drawing.Point(206, 55);
            this.panel_orta.Name = "panel_orta";
            this.panel_orta.Size = new System.Drawing.Size(817, 545);
            this.panel_orta.TabIndex = 18;
            this.panel_orta.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_orta_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(52, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 96);
            this.label2.TabIndex = 1;
            this.label2.Text = "HOŞGELDİNİZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(55, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hetro Turizm\'e";
            // 
            // ana_panel
            // 
            this.ana_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ana_panel.Controls.Add(this.panel_orta);
            this.ana_panel.Controls.Add(this.panel_sol);
            this.ana_panel.Controls.Add(this.baslik);
            this.ana_panel.Location = new System.Drawing.Point(0, 0);
            this.ana_panel.Name = "ana_panel";
            this.ana_panel.Size = new System.Drawing.Size(1013, 613);
            this.ana_panel.TabIndex = 0;
            // 
            // btnOtobus
            // 
            this.btnOtobus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.btnOtobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnOtobus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOtobus.BorderRadius = 0;
            this.btnOtobus.ButtonText = "       Otobüs Ekle";
            this.btnOtobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtobus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOtobus.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOtobus.Iconimage")));
            this.btnOtobus.Iconimage_right = null;
            this.btnOtobus.Iconimage_right_Selected = null;
            this.btnOtobus.Iconimage_Selected = null;
            this.btnOtobus.IconZoom = 35D;
            this.btnOtobus.IsTab = false;
            this.btnOtobus.Location = new System.Drawing.Point(-5, 390);
            this.btnOtobus.Name = "btnOtobus";
            this.btnOtobus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnOtobus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(115)))));
            this.btnOtobus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOtobus.selected = false;
            this.btnOtobus.Size = new System.Drawing.Size(213, 48);
            this.btnOtobus.TabIndex = 4;
            this.btnOtobus.Textcolor = System.Drawing.Color.White;
            this.btnOtobus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtobus.Click += new System.EventHandler(this.btnOtobus_Click);
            // 
            // btnSefer
            // 
            this.btnSefer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.btnSefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnSefer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSefer.BorderRadius = 0;
            this.btnSefer.ButtonText = "       Seferler";
            this.btnSefer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSefer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSefer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSefer.Iconimage")));
            this.btnSefer.Iconimage_right = null;
            this.btnSefer.Iconimage_right_Selected = null;
            this.btnSefer.Iconimage_Selected = null;
            this.btnSefer.IconZoom = 35D;
            this.btnSefer.IsTab = false;
            this.btnSefer.Location = new System.Drawing.Point(-5, 321);
            this.btnSefer.Name = "btnSefer";
            this.btnSefer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnSefer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(115)))));
            this.btnSefer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSefer.selected = false;
            this.btnSefer.Size = new System.Drawing.Size(213, 48);
            this.btnSefer.TabIndex = 3;
            this.btnSefer.Textcolor = System.Drawing.Color.White;
            this.btnSefer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSefer.Click += new System.EventHandler(this.btnSefer_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.btnPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnPersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonel.BorderRadius = 0;
            this.btnPersonel.ButtonText = "       Personel";
            this.btnPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPersonel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPersonel.Iconimage")));
            this.btnPersonel.Iconimage_right = null;
            this.btnPersonel.Iconimage_right_Selected = null;
            this.btnPersonel.Iconimage_Selected = null;
            this.btnPersonel.IconZoom = 35D;
            this.btnPersonel.IsTab = false;
            this.btnPersonel.Location = new System.Drawing.Point(-5, 252);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnPersonel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(115)))));
            this.btnPersonel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPersonel.selected = false;
            this.btnPersonel.Size = new System.Drawing.Size(213, 48);
            this.btnPersonel.TabIndex = 2;
            this.btnPersonel.Textcolor = System.Drawing.Color.White;
            this.btnPersonel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonel.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_bilet
            // 
            this.btn_bilet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.btn_bilet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btn_bilet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bilet.BorderRadius = 0;
            this.btn_bilet.ButtonText = "       Bilet İşlemleri";
            this.btn_bilet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bilet.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_bilet.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_bilet.Iconimage")));
            this.btn_bilet.Iconimage_right = null;
            this.btn_bilet.Iconimage_right_Selected = null;
            this.btn_bilet.Iconimage_Selected = null;
            this.btn_bilet.IconZoom = 35D;
            this.btn_bilet.IsTab = false;
            this.btn_bilet.Location = new System.Drawing.Point(-5, 183);
            this.btn_bilet.Name = "btn_bilet";
            this.btn_bilet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btn_bilet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(115)))));
            this.btn_bilet.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_bilet.selected = false;
            this.btn_bilet.Size = new System.Drawing.Size(213, 48);
            this.btn_bilet.TabIndex = 1;
            this.btn_bilet.Textcolor = System.Drawing.Color.White;
            this.btn_bilet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bilet.Click += new System.EventHandler(this.btn_bilet_Click);
            // 
            // btn_uyelik
            // 
            this.btn_uyelik.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.btn_uyelik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btn_uyelik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_uyelik.BorderRadius = 0;
            this.btn_uyelik.ButtonText = "       Kart Üyeliği";
            this.btn_uyelik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uyelik.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_uyelik.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_uyelik.Iconimage")));
            this.btn_uyelik.Iconimage_right = null;
            this.btn_uyelik.Iconimage_right_Selected = null;
            this.btn_uyelik.Iconimage_Selected = null;
            this.btn_uyelik.IconZoom = 35D;
            this.btn_uyelik.IsTab = false;
            this.btn_uyelik.Location = new System.Drawing.Point(-5, 114);
            this.btn_uyelik.Name = "btn_uyelik";
            this.btn_uyelik.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btn_uyelik.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(115)))));
            this.btn_uyelik.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_uyelik.selected = false;
            this.btn_uyelik.Size = new System.Drawing.Size(213, 48);
            this.btn_uyelik.TabIndex = 0;
            this.btn_uyelik.Textcolor = System.Drawing.Color.White;
            this.btn_uyelik.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uyelik.Click += new System.EventHandler(this.btn_uyelik_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(971, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 600);
            this.Controls.Add(this.ana_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.baslik.ResumeLayout(false);
            this.baslik.PerformLayout();
            this.panel_sol.ResumeLayout(false);
            this.panel_sol.PerformLayout();
            this.panel_orta.ResumeLayout(false);
            this.panel_orta.PerformLayout();
            this.ana_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel baslik;
        private System.Windows.Forms.Panel panel_sol;
        private Bunifu.Framework.UI.BunifuFlatButton btn_uyelik;
        private Bunifu.Framework.UI.BunifuFlatButton btn_bilet;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_orta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel header_label;
        private Bunifu.Framework.UI.BunifuFlatButton btnPersonel;
        private System.Windows.Forms.Panel ana_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSefer;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnOtobus;
    }
}