namespace EduBrilliant.UserControlsGuru
{
	partial class UCSoalItems
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
			this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
			this.lblJawaban = new System.Windows.Forms.Label();
			this.txtSoal = new System.Windows.Forms.RichTextBox();
			this.lblNo = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnHapus
			// 
			this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnHapus.FillColor = System.Drawing.Color.OrangeRed;
			this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHapus.ForeColor = System.Drawing.Color.White;
			this.btnHapus.Location = new System.Drawing.Point(236, 4);
			this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(83, 19);
			this.btnHapus.TabIndex = 7;
			this.btnHapus.Text = "Hapus";
			// 
			// lblJawaban
			// 
			this.lblJawaban.AutoSize = true;
			this.lblJawaban.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJawaban.Location = new System.Drawing.Point(118, 4);
			this.lblJawaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblJawaban.Name = "lblJawaban";
			this.lblJawaban.Size = new System.Drawing.Size(81, 19);
			this.lblJawaban.TabIndex = 6;
			this.lblJawaban.Text = "Jawaban : A";
			// 
			// txtSoal
			// 
			this.txtSoal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoal.Location = new System.Drawing.Point(7, 27);
			this.txtSoal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSoal.Name = "txtSoal";
			this.txtSoal.Size = new System.Drawing.Size(312, 131);
			this.txtSoal.TabIndex = 5;
			this.txtSoal.Text = "";
			// 
			// lblNo
			// 
			this.lblNo.AutoSize = true;
			this.lblNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNo.Location = new System.Drawing.Point(4, 4);
			this.lblNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNo.Name = "lblNo";
			this.lblNo.Size = new System.Drawing.Size(49, 19);
			this.lblNo.TabIndex = 4;
			this.lblNo.Text = "No. : 1";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.White;
			this.lblID.Location = new System.Drawing.Point(72, 4);
			this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(17, 19);
			this.lblID.TabIndex = 8;
			this.lblID.Text = "1";
			this.lblID.Click += new System.EventHandler(this.label1_Click);
			// 
			// UCSoalItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.lblJawaban);
			this.Controls.Add(this.txtSoal);
			this.Controls.Add(this.lblNo);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "UCSoalItems";
			this.Size = new System.Drawing.Size(323, 164);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblJawaban;
		private System.Windows.Forms.RichTextBox txtSoal;
		private System.Windows.Forms.Label lblNo;
		private Guna.UI2.WinForms.Guna2Button btnHapus;
		private System.Windows.Forms.Label lblID;
	}
}
