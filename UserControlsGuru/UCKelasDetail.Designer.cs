namespace EduBrilliant.UserControlsGuru
{
	partial class UCKelasDetail
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
			this.lblNama = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowPanelSoal = new System.Windows.Forms.FlowLayoutPanel();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbKategori = new Guna.UI2.WinForms.Guna2ComboBox();
			this.numHarga = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNama
			// 
			this.lblNama.AutoSize = true;
			this.lblNama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNama.Location = new System.Drawing.Point(352, 66);
			this.lblNama.Name = "lblNama";
			this.lblNama.Size = new System.Drawing.Size(45, 19);
			this.lblNama.TabIndex = 0;
			this.lblNama.Text = "Nama";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.flowPanelSoal);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(343, 410);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Soal";
			// 
			// flowPanelSoal
			// 
			this.flowPanelSoal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowPanelSoal.Location = new System.Drawing.Point(3, 21);
			this.flowPanelSoal.Name = "flowPanelSoal";
			this.flowPanelSoal.Size = new System.Drawing.Size(337, 386);
			this.flowPanelSoal.TabIndex = 0;
			this.flowPanelSoal.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// guna2Button1
			// 
			this.guna2Button1.BorderRadius = 3;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.OrangeRed;
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(512, 285);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(134, 34);
			this.guna2Button1.TabIndex = 2;
			this.guna2Button1.Text = "Hapus";
			// 
			// guna2Button2
			// 
			this.guna2Button2.BorderRadius = 3;
			this.guna2Button2.BorderThickness = 1;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.FillColor = System.Drawing.Color.White;
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button2.ForeColor = System.Drawing.Color.Black;
			this.guna2Button2.Location = new System.Drawing.Point(372, 285);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(134, 34);
			this.guna2Button2.TabIndex = 3;
			this.guna2Button2.Text = "Edit";
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
			this.guna2TextBox1.BorderRadius = 3;
			this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
			this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Location = new System.Drawing.Point(356, 88);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderText = "";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.Size = new System.Drawing.Size(306, 36);
			this.guna2TextBox1.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(473, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 31);
			this.label4.TabIndex = 11;
			this.label4.Text = "Kelas";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(352, 208);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 19);
			this.label8.TabIndex = 15;
			this.label8.Text = "Harga";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(352, 137);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 19);
			this.label7.TabIndex = 14;
			this.label7.Text = "Kategori";
			// 
			// cbKategori
			// 
			this.cbKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbKategori.BackColor = System.Drawing.Color.Transparent;
			this.cbKategori.BorderColor = System.Drawing.Color.Black;
			this.cbKategori.BorderRadius = 3;
			this.cbKategori.DisplayMember = "Nama";
			this.cbKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbKategori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbKategori.ForeColor = System.Drawing.Color.Black;
			this.cbKategori.ItemHeight = 30;
			this.cbKategori.Location = new System.Drawing.Point(356, 159);
			this.cbKategori.Name = "cbKategori";
			this.cbKategori.Size = new System.Drawing.Size(306, 36);
			this.cbKategori.TabIndex = 13;
			this.cbKategori.ValueMember = "ID";
			// 
			// numHarga
			// 
			this.numHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			this.numHarga.Location = new System.Drawing.Point(356, 230);
			this.numHarga.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numHarga.Name = "numHarga";
			this.numHarga.Size = new System.Drawing.Size(306, 34);
			this.numHarga.TabIndex = 12;
			this.numHarga.ThousandsSeparator = true;
			this.numHarga.UpDownButtonFillColor = System.Drawing.Color.White;
			this.numHarga.UpDownButtonForeColor = System.Drawing.Color.Black;
			// 
			// UCKelasDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbKategori);
			this.Controls.Add(this.numHarga);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.guna2TextBox1);
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblNama);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UCKelasDetail";
			this.Size = new System.Drawing.Size(675, 579);
			this.Load += new System.EventHandler(this.UCKelasDetail_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNama;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel flowPanelSoal;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2ComboBox cbKategori;
		private Guna.UI2.WinForms.Guna2NumericUpDown numHarga;
	}
}
