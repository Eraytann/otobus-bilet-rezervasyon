namespace Otobus
{
    partial class BiletAl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletAl));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_orta = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SeferNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlakaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nerden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nereye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarihColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslik = new System.Windows.Forms.Panel();
            this.btnBul = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxNereye = new System.Windows.Forms.ComboBox();
            this.cBoxNerden = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_orta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.baslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_orta
            // 
            this.panel_orta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_orta.Controls.Add(this.dataGridView1);
            this.panel_orta.Controls.Add(this.baslik);
            this.panel_orta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_orta.Location = new System.Drawing.Point(0, -4);
            this.panel_orta.Name = "panel_orta";
            this.panel_orta.Size = new System.Drawing.Size(805, 549);
            this.panel_orta.TabIndex = 6;
            this.panel_orta.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_orta_Paint);
            this.panel_orta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_orta_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeferNoColumn,
            this.PlakaColumn,
            this.Nerden,
            this.Nereye,
            this.Saat,
            this.TarihColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 482);
            this.dataGridView1.TabIndex = 211;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // SeferNoColumn
            // 
            this.SeferNoColumn.HeaderText = "SeferNo";
            this.SeferNoColumn.Name = "SeferNoColumn";
            this.SeferNoColumn.ReadOnly = true;
            this.SeferNoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeferNoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SeferNoColumn.Width = 90;
            // 
            // PlakaColumn
            // 
            this.PlakaColumn.HeaderText = "Plaka";
            this.PlakaColumn.Name = "PlakaColumn";
            this.PlakaColumn.ReadOnly = true;
            this.PlakaColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlakaColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nerden
            // 
            this.Nerden.HeaderText = "Nerden";
            this.Nerden.Name = "Nerden";
            this.Nerden.ReadOnly = true;
            this.Nerden.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nerden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nerden.Width = 190;
            // 
            // Nereye
            // 
            this.Nereye.HeaderText = "Nereye";
            this.Nereye.Name = "Nereye";
            this.Nereye.ReadOnly = true;
            this.Nereye.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nereye.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nereye.Width = 190;
            // 
            // Saat
            // 
            this.Saat.HeaderText = "Saat";
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            this.Saat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Saat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Saat.Width = 80;
            // 
            // TarihColumn
            // 
            this.TarihColumn.HeaderText = "Tarih";
            this.TarihColumn.Name = "TarihColumn";
            this.TarihColumn.ReadOnly = true;
            this.TarihColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TarihColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TarihColumn.Width = 110;
            // 
            // baslik
            // 
            this.baslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(65)))), ((int)(((byte)(108)))));
            this.baslik.Controls.Add(this.btnBul);
            this.baslik.Controls.Add(this.pictureBox2);
            this.baslik.Controls.Add(this.Tarih);
            this.baslik.Controls.Add(this.label1);
            this.baslik.Controls.Add(this.pictureBox4);
            this.baslik.Controls.Add(this.label8);
            this.baslik.Controls.Add(this.cBoxNereye);
            this.baslik.Controls.Add(this.cBoxNerden);
            this.baslik.Controls.Add(this.label7);
            this.baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.baslik.Location = new System.Drawing.Point(0, 0);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(805, 61);
            this.baslik.TabIndex = 199;
            this.baslik.Paint += new System.Windows.Forms.PaintEventHandler(this.baslik_Paint);
            // 
            // btnBul
            // 
            this.btnBul.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(105)))));
            this.btnBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBul.BorderRadius = 0;
            this.btnBul.ButtonText = "";
            this.btnBul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBul.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBul.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBul.Iconimage")));
            this.btnBul.Iconimage_right = null;
            this.btnBul.Iconimage_right_Selected = null;
            this.btnBul.Iconimage_Selected = null;
            this.btnBul.IconZoom = 50D;
            this.btnBul.IsTab = false;
            this.btnBul.Location = new System.Drawing.Point(727, 14);
            this.btnBul.Name = "btnBul";
            this.btnBul.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnBul.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(115)))));
            this.btnBul.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBul.selected = false;
            this.btnBul.Size = new System.Drawing.Size(41, 35);
            this.btnBul.TabIndex = 201;
            this.btnBul.Textcolor = System.Drawing.Color.White;
            this.btnBul.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(971, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Tarih
            // 
            this.Tarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarih.Location = new System.Drawing.Point(590, 22);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(131, 22);
            this.Tarih.TabIndex = 199;
            this.Tarih.ValueChanged += new System.EventHandler(this.Tarih_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(539, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 200;
            this.label1.Text = "Tarih:";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label8.Location = new System.Drawing.Point(62, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nereden:";
            // 
            // cBoxNereye
            // 
            this.cBoxNereye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxNereye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBoxNereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxNereye.FormattingEnabled = true;
            this.cBoxNereye.Location = new System.Drawing.Point(379, 24);
            this.cBoxNereye.Name = "cBoxNereye";
            this.cBoxNereye.Size = new System.Drawing.Size(154, 23);
            this.cBoxNereye.TabIndex = 17;
            // 
            // cBoxNerden
            // 
            this.cBoxNerden.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxNerden.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBoxNerden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxNerden.FormattingEnabled = true;
            this.cBoxNerden.Location = new System.Drawing.Point(146, 24);
            this.cBoxNerden.Name = "cBoxNerden";
            this.cBoxNerden.Size = new System.Drawing.Size(154, 23);
            this.cBoxNerden.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(306, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nereye:";
            // 
            // BiletAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 545);
            this.Controls.Add(this.panel_orta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BiletAl";
            this.Text = "BiletAl";
            this.Load += new System.EventHandler(this.BiletAl_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BiletAl_MouseClick);
            this.panel_orta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.baslik.ResumeLayout(false);
            this.baslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_orta;
        private System.Windows.Forms.Panel baslik;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cBoxNereye;
        private System.Windows.Forms.ComboBox cBoxNerden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton btnBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeferNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlakaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nerden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nereye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarihColumn;
    }
}