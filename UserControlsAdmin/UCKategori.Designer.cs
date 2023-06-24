namespace EduBrilliant.UserControls
{
	partial class UCKategori
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
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvKategori = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnInsert = new Guna.UI2.WinForms.Guna2Button();
			this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
			this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.KategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			nameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.KategoriBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			nameLabel.AutoSize = true;
			nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nameLabel.Location = new System.Drawing.Point(147, 378);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(45, 19);
			nameLabel.TabIndex = 13;
			nameLabel.Text = "Nama";
			// 
			// dgvKategori
			// 
			this.dgvKategori.AllowUserToAddRows = false;
			this.dgvKategori.AllowUserToDeleteRows = false;
			this.dgvKategori.AllowUserToOrderColumns = true;
			this.dgvKategori.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvKategori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvKategori.AutoGenerateColumns = false;
			this.dgvKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvKategori.BackgroundColor = System.Drawing.Color.White;
			this.dgvKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKategori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1});
			this.dgvKategori.DataSource = this.KategoriBindingSource;
			this.dgvKategori.Location = new System.Drawing.Point(3, 37);
			this.dgvKategori.Name = "dgvKategori";
			this.dgvKategori.ReadOnly = true;
			this.dgvKategori.RowHeadersVisible = false;
			this.dgvKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKategori.Size = new System.Drawing.Size(669, 280);
			this.dgvKategori.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Nama";
			this.Column1.HeaderText = "Nama";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 61;
			// 
			// btnInsert
			// 
			this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnInsert.BorderRadius = 3;
			this.btnInsert.BorderThickness = 1;
			this.btnInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnInsert.FillColor = System.Drawing.Color.White;
			this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnInsert.ForeColor = System.Drawing.Color.Black;
			this.btnInsert.Location = new System.Drawing.Point(151, 430);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(104, 28);
			this.btnInsert.TabIndex = 17;
			this.btnInsert.Text = "Insert";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnUpdate.BorderRadius = 3;
			this.btnUpdate.BorderThickness = 1;
			this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnUpdate.FillColor = System.Drawing.Color.White;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnUpdate.ForeColor = System.Drawing.Color.Black;
			this.btnUpdate.Location = new System.Drawing.Point(278, 430);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(104, 28);
			this.btnUpdate.TabIndex = 18;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnDelete.BorderRadius = 3;
			this.btnDelete.BorderThickness = 1;
			this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDelete.FillColor = System.Drawing.Color.White;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnDelete.ForeColor = System.Drawing.Color.Black;
			this.btnDelete.Location = new System.Drawing.Point(404, 430);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(104, 28);
			this.btnDelete.TabIndex = 19;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.BorderRadius = 3;
			this.btnSave.BorderThickness = 1;
			this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSave.Enabled = false;
			this.btnSave.FillColor = System.Drawing.Color.CornflowerBlue;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(212, 480);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 28);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.BorderRadius = 3;
			this.btnCancel.BorderThickness = 1;
			this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCancel.Enabled = false;
			this.btnCancel.FillColor = System.Drawing.Color.OrangeRed;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(346, 480);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(104, 28);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 28);
			this.label2.TabIndex = 23;
			this.label2.Text = "Kategori";
			// 
			// txtNama
			// 
			this.txtNama.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KategoriBindingSource, "Nama", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtNama.Enabled = false;
			this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNama.Location = new System.Drawing.Point(278, 375);
			this.txtNama.Margin = new System.Windows.Forms.Padding(6);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(221, 25);
			this.txtNama.TabIndex = 14;
			// 
			// KategoriBindingSource
			// 
			this.KategoriBindingSource.AllowNew = true;
			this.KategoriBindingSource.DataSource = typeof(EduBrilliant.Kategori);
			this.KategoriBindingSource.Filter = "";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 43;
			// 
			// UCKategori
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.dgvKategori);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UCKategori";
			this.Size = new System.Drawing.Size(675, 579);
			this.Load += new System.EventHandler(this.UCKategori_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.KategoriBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource KategoriBindingSource;
		private System.Windows.Forms.DataGridView dgvKategori;
		private Guna.UI2.WinForms.Guna2Button btnUpdate;
		private Guna.UI2.WinForms.Guna2Button btnDelete;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private Guna.UI2.WinForms.Guna2Button btnCancel;
		private Guna.UI2.WinForms.Guna2Button btnInsert;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.TextBox txtNama;
	}
}
