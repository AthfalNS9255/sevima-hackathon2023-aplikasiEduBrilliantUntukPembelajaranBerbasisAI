namespace EduBrilliant.UserControls
{
	partial class UCTransaksi
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvSiswa = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KelasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TransaksiBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSiswa
			// 
			this.dgvSiswa.AllowUserToAddRows = false;
			this.dgvSiswa.AllowUserToDeleteRows = false;
			this.dgvSiswa.AllowUserToOrderColumns = true;
			this.dgvSiswa.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvSiswa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSiswa.AutoGenerateColumns = false;
			this.dgvSiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSiswa.BackgroundColor = System.Drawing.Color.White;
			this.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Kelas,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.KelasID});
			this.dgvSiswa.DataSource = this.TransaksiBindingSource;
			this.dgvSiswa.Location = new System.Drawing.Point(3, 37);
			this.dgvSiswa.Name = "dgvSiswa";
			this.dgvSiswa.ReadOnly = true;
			this.dgvSiswa.RowHeadersVisible = false;
			this.dgvSiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSiswa.Size = new System.Drawing.Size(669, 539);
			this.dgvSiswa.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Siswa";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// Kelas
			// 
			this.Kelas.HeaderText = "Kelas";
			this.Kelas.Name = "Kelas";
			this.Kelas.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Token";
			this.dataGridViewTextBoxColumn3.HeaderText = "Token";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "IsActive";
			this.dataGridViewTextBoxColumn2.HeaderText = "IsActive";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "UserID";
			this.dataGridViewTextBoxColumn5.HeaderText = "UserID";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// KelasID
			// 
			this.KelasID.DataPropertyName = "KelasID";
			this.KelasID.HeaderText = "KelasID";
			this.KelasID.Name = "KelasID";
			this.KelasID.ReadOnly = true;
			this.KelasID.Visible = false;
			// 
			// TransaksiBindingSource
			// 
			this.TransaksiBindingSource.AllowNew = true;
			this.TransaksiBindingSource.DataSource = typeof(EduBrilliant.Transaksi);
			this.TransaksiBindingSource.Filter = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 28);
			this.label2.TabIndex = 22;
			this.label2.Text = "Transaksi";
			// 
			// UCTransaksi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvSiswa);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UCTransaksi";
			this.Size = new System.Drawing.Size(675, 579);
			this.Load += new System.EventHandler(this.UCTransaksi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TransaksiBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvSiswa;
		private System.Windows.Forms.BindingSource TransaksiBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kelas;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn KelasID;
	}
}
