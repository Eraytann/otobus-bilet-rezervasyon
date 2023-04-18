namespace Otobus
{
    partial class Biletİptali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biletİptali));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel_orta = new System.Windows.Forms.Panel();
            this.btn_iptal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_orta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(432, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 200;
            this.label1.Text = "Müşteri No:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 199;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel_orta
            // 
            this.panel_orta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(65)))), ((int)(((byte)(108)))));
            this.panel_orta.Controls.Add(this.label1);
            this.panel_orta.Controls.Add(this.btn_iptal);
            this.panel_orta.Controls.Add(this.pictureBox4);
            this.panel_orta.Controls.Add(this.txtMusteriNo);
            this.panel_orta.Controls.Add(this.dataGridView1);
            this.panel_orta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_orta.Location = new System.Drawing.Point(0, -1);
            this.panel_orta.Name = "panel_orta";
            this.panel_orta.Size = new System.Drawing.Size(805, 546);
            this.panel_orta.TabIndex = 4;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.btn_iptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btn_iptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_iptal.BorderRadius = 0;
            this.btn_iptal.ButtonText = "Bileti İptal Et";
            this.btn_iptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iptal.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_iptal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_iptal.Iconimage")));
            this.btn_iptal.Iconimage_right = null;
            this.btn_iptal.Iconimage_right_Selected = null;
            this.btn_iptal.Iconimage_Selected = null;
            this.btn_iptal.IconZoom = 35D;
            this.btn_iptal.IsTab = false;
            this.btn_iptal.Location = new System.Drawing.Point(654, 12);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btn_iptal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(115)))));
            this.btn_iptal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btn_iptal.selected = false;
            this.btn_iptal.Size = new System.Drawing.Size(139, 46);
            this.btn_iptal.TabIndex = 3;
            this.btn_iptal.Textcolor = System.Drawing.Color.White;
            this.btn_iptal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriNo.Location = new System.Drawing.Point(534, 21);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(114, 26);
            this.txtMusteriNo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(805, 472);
            this.dataGridView1.TabIndex = 2;
            // 
            // Biletİptali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 545);
            this.Controls.Add(this.panel_orta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Biletİptali";
            this.Text = "Biletİptali";
            this.Load += new System.EventHandler(this.Biletİptali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_orta.ResumeLayout(false);
            this.panel_orta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel_orta;
        private Bunifu.Framework.UI.BunifuFlatButton btn_iptal;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}