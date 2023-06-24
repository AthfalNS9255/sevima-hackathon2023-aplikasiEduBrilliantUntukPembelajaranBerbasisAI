namespace EduBrilliant.UserControlsGuru
{
	partial class UCKelasGuru
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.flowPanelKelas = new System.Windows.Forms.FlowLayoutPanel();
			this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
			this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
			this.numHarga = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.cbKategori = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cbKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbKategoriBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// flowPanelKelas
			// 
			this.flowPanelKelas.AutoScroll = true;
			this.flowPanelKelas.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowPanelKelas.Location = new System.Drawing.Point(0, 0);
			this.flowPanelKelas.Name = "flowPanelKelas";
			this.flowPanelKelas.Padding = new System.Windows.Forms.Padding(10);
			this.flowPanelKelas.Size = new System.Drawing.Size(475, 579);
			this.flowPanelKelas.TabIndex = 0;
			// 
			// btnTambah
			// 
			this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTambah.BorderRadius = 3;
			this.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTambah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(47)))));
			this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnTambah.ForeColor = System.Drawing.Color.White;
			this.btnTambah.Location = new System.Drawing.Point(480, 278);
			this.btnTambah.Name = "btnTambah";
			this.btnTambah.Size = new System.Drawing.Size(189, 33);
			this.btnTambah.TabIndex = 1;
			this.btnTambah.Text = "Tambah Kelas";
			this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
			// 
			// txtNama
			// 
			this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNama.BorderColor = System.Drawing.Color.Black;
			this.txtNama.BorderRadius = 3;
			this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNama.DefaultText = "";
			this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtNama.ForeColor = System.Drawing.Color.Black;
			this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtNama.Location = new System.Drawing.Point(481, 95);
			this.txtNama.Name = "txtNama";
			this.txtNama.PasswordChar = '\0';
			this.txtNama.PlaceholderText = "";
			this.txtNama.SelectedText = "";
			this.txtNama.Size = new System.Drawing.Size(189, 36);
			this.txtNama.TabIndex = 2;
			// 
			// numHarga
			// 
			this.numHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numHarga.BackColor = System.Drawing.Color.Transparent;
			this.numHarga.BorderColor = System.Drawing.Color.Black;
			this.numHarga.BorderRadius = 3;
			this.numHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.numHarga.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.numHarga.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numHarga.Location = new System.Drawing.Point(481, 221);
			this.numHarga.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numHarga.Name = "numHarga";
			this.numHarga.Size = new System.Drawing.Size(189, 34);
			this.numHarga.TabIndex = 3;
			this.numHarga.ThousandsSeparator = true;
			this.numHarga.UpDownButtonFillColor = System.Drawing.Color.White;
			this.numHarga.UpDownButtonForeColor = System.Drawing.Color.Black;
			// 
			// cbKategori
			// 
			this.cbKategori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbKategori.BackColor = System.Drawing.Color.Transparent;
			this.cbKategori.BorderColor = System.Drawing.Color.Black;
			this.cbKategori.BorderRadius = 3;
			this.cbKategori.DataSource = this.cbKategoriBindingSource;
			this.cbKategori.DisplayMember = "Nama";
			this.cbKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbKategori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbKategori.ForeColor = System.Drawing.Color.Black;
			this.cbKategori.ItemHeight = 30;
			this.cbKategori.Location = new System.Drawing.Point(480, 159);
			this.cbKategori.Name = "cbKategori";
			this.cbKategori.Size = new System.Drawing.Size(189, 36);
			this.cbKategori.TabIndex = 4;
			this.cbKategori.ValueMember = "ID";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(482, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Nama";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(481, 143);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Kategori";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(482, 205);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Harga";
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(534, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 37);
			this.label9.TabIndex = 8;
			this.label9.Text = "Kelas";
			// 
			// cbKategoriBindingSource
			// 
			this.cbKategoriBindingSource.DataSource = typeof(EduBrilliant.Kategori);
			// 
			// UCKelasGuru
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbKategori);
			this.Controls.Add(this.numHarga);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.btnTambah);
			this.Controls.Add(this.flowPanelKelas);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UCKelasGuru";
			this.Size = new System.Drawing.Size(675, 579);
			this.Load += new System.EventHandler(this.UCKelasGuru_Load);
			((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbKategoriBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowPanelKelas;
		private Guna.UI2.WinForms.Guna2Button btnTambah;
		private Guna.UI2.WinForms.Guna2TextBox txtNama;
		private Guna.UI2.WinForms.Guna2NumericUpDown numHarga;
		private Guna.UI2.WinForms.Guna2ComboBox cbKategori;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.BindingSource cbKategoriBindingSource;
	}
}
