namespace EduBrilliant.UserControls
{
	partial class UCSiswa
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
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label namaLengkapLabel;
			System.Windows.Forms.Label noTelpLabel;
			System.Windows.Forms.Label passwordLabel;
			System.Windows.Forms.Label usernameLabel;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvSiswa = new System.Windows.Forms.DataGridView();
			this.btnInsert = new Guna.UI2.WinForms.Guna2Button();
			this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
			this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtNoTelp = new System.Windows.Forms.TextBox();
			this.txtNamaLengkap = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			emailLabel = new System.Windows.Forms.Label();
			namaLengkapLabel = new System.Windows.Forms.Label();
			noTelpLabel = new System.Windows.Forms.Label();
			passwordLabel = new System.Windows.Forms.Label();
			usernameLabel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SiswaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// emailLabel
			// 
			emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			emailLabel.AutoSize = true;
			emailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			emailLabel.Location = new System.Drawing.Point(60, 345);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(44, 19);
			emailLabel.TabIndex = 1;
			emailLabel.Text = "Email:";
			// 
			// namaLengkapLabel
			// 
			namaLengkapLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			namaLengkapLabel.AutoSize = true;
			namaLengkapLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			namaLengkapLabel.Location = new System.Drawing.Point(60, 422);
			namaLengkapLabel.Name = "namaLengkapLabel";
			namaLengkapLabel.Size = new System.Drawing.Size(104, 19);
			namaLengkapLabel.TabIndex = 5;
			namaLengkapLabel.Text = "Nama Lengkap:";
			// 
			// noTelpLabel
			// 
			noTelpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			noTelpLabel.AutoSize = true;
			noTelpLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			noTelpLabel.Location = new System.Drawing.Point(60, 459);
			noTelpLabel.Name = "noTelpLabel";
			noTelpLabel.Size = new System.Drawing.Size(61, 19);
			noTelpLabel.TabIndex = 7;
			noTelpLabel.Text = "No. Telp:";
			// 
			// passwordLabel
			// 
			passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			passwordLabel.AutoSize = true;
			passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			passwordLabel.Location = new System.Drawing.Point(60, 496);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new System.Drawing.Size(70, 19);
			passwordLabel.TabIndex = 9;
			passwordLabel.Text = "Password:";
			// 
			// usernameLabel
			// 
			usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			usernameLabel.AutoSize = true;
			usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			usernameLabel.Location = new System.Drawing.Point(60, 385);
			usernameLabel.Name = "usernameLabel";
			usernameLabel.Size = new System.Drawing.Size(74, 19);
			usernameLabel.TabIndex = 13;
			usernameLabel.Text = "Username:";
			// 
			// label1
			// 
			label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label1.Location = new System.Drawing.Point(60, 533);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(123, 19);
			label1.TabIndex = 15;
			label1.Text = "Confirm Password:";
			// 
			// dgvSiswa
			// 
			this.dgvSiswa.AllowUserToAddRows = false;
			this.dgvSiswa.AllowUserToDeleteRows = false;
			this.dgvSiswa.AllowUserToOrderColumns = true;
			this.dgvSiswa.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvSiswa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSiswa.AutoGenerateColumns = false;
			this.dgvSiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSiswa.BackgroundColor = System.Drawing.Color.White;
			this.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.dgvSiswa.DataSource = this.SiswaBindingSource;
			this.dgvSiswa.Location = new System.Drawing.Point(3, 37);
			this.dgvSiswa.Name = "dgvSiswa";
			this.dgvSiswa.ReadOnly = true;
			this.dgvSiswa.RowHeadersVisible = false;
			this.dgvSiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSiswa.Size = new System.Drawing.Size(669, 280);
			this.dgvSiswa.TabIndex = 0;
			// 
			// btnInsert
			// 
			this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInsert.BorderRadius = 3;
			this.btnInsert.BorderThickness = 1;
			this.btnInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnInsert.FillColor = System.Drawing.Color.White;
			this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnInsert.ForeColor = System.Drawing.Color.Black;
			this.btnInsert.Location = new System.Drawing.Point(495, 361);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(104, 28);
			this.btnInsert.TabIndex = 17;
			this.btnInsert.Text = "Insert";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.BorderRadius = 3;
			this.btnUpdate.BorderThickness = 1;
			this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnUpdate.FillColor = System.Drawing.Color.White;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnUpdate.ForeColor = System.Drawing.Color.Black;
			this.btnUpdate.Location = new System.Drawing.Point(495, 407);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(104, 28);
			this.btnUpdate.TabIndex = 18;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.BorderRadius = 3;
			this.btnDelete.BorderThickness = 1;
			this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDelete.FillColor = System.Drawing.Color.White;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnDelete.ForeColor = System.Drawing.Color.Black;
			this.btnDelete.Location = new System.Drawing.Point(495, 453);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(104, 28);
			this.btnDelete.TabIndex = 19;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnSave.Location = new System.Drawing.Point(441, 502);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 28);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnCancel.Location = new System.Drawing.Point(551, 502);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(104, 28);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SiswaBindingSource, "Username", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtUsername.Enabled = false;
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(191, 382);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(221, 25);
			this.txtUsername.TabIndex = 14;
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Enabled = false;
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(191, 493);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(221, 25);
			this.txtPassword.TabIndex = 10;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtNoTelp
			// 
			this.txtNoTelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNoTelp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SiswaBindingSource, "NoTelp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtNoTelp.Enabled = false;
			this.txtNoTelp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNoTelp.Location = new System.Drawing.Point(191, 456);
			this.txtNoTelp.Margin = new System.Windows.Forms.Padding(6);
			this.txtNoTelp.Name = "txtNoTelp";
			this.txtNoTelp.Size = new System.Drawing.Size(221, 25);
			this.txtNoTelp.TabIndex = 8;
			// 
			// txtNamaLengkap
			// 
			this.txtNamaLengkap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNamaLengkap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SiswaBindingSource, "NamaLengkap", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtNamaLengkap.Enabled = false;
			this.txtNamaLengkap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNamaLengkap.Location = new System.Drawing.Point(191, 419);
			this.txtNamaLengkap.Margin = new System.Windows.Forms.Padding(6);
			this.txtNamaLengkap.Name = "txtNamaLengkap";
			this.txtNamaLengkap.Size = new System.Drawing.Size(221, 25);
			this.txtNamaLengkap.TabIndex = 6;
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SiswaBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.Never));
			this.txtEmail.Enabled = false;
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(191, 345);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(221, 25);
			this.txtEmail.TabIndex = 2;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConfirmPassword.Enabled = false;
			this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmPassword.Location = new System.Drawing.Point(191, 530);
			this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(6);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(221, 25);
			this.txtConfirmPassword.TabIndex = 16;
			this.txtConfirmPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 28);
			this.label2.TabIndex = 22;
			this.label2.Text = "Siswa";
			// 
			// SiswaBindingSource
			// 
			this.SiswaBindingSource.AllowNew = true;
			this.SiswaBindingSource.DataSource = typeof(EduBrilliant.User);
			this.SiswaBindingSource.Filter = "";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaLengkap";
			this.dataGridViewTextBoxColumn2.HeaderText = "Nama Lengkap";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Username";
			this.dataGridViewTextBoxColumn3.HeaderText = "Username";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "NoTelp";
			this.dataGridViewTextBoxColumn5.HeaderText = "NoTelp";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
			this.dataGridViewTextBoxColumn6.HeaderText = "Email";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// UCSiswa
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
			this.Controls.Add(label1);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(emailLabel);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(namaLengkapLabel);
			this.Controls.Add(this.txtNamaLengkap);
			this.Controls.Add(noTelpLabel);
			this.Controls.Add(this.txtNoTelp);
			this.Controls.Add(passwordLabel);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(usernameLabel);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.dgvSiswa);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UCSiswa";
			this.Size = new System.Drawing.Size(675, 579);
			this.Load += new System.EventHandler(this.UCSiswa_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SiswaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvSiswa;
		private Guna.UI2.WinForms.Guna2Button btnUpdate;
		private Guna.UI2.WinForms.Guna2Button btnDelete;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private Guna.UI2.WinForms.Guna2Button btnCancel;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtNoTelp;
		private System.Windows.Forms.TextBox txtNamaLengkap;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private Guna.UI2.WinForms.Guna2Button btnInsert;
		private System.Windows.Forms.BindingSource SiswaBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}
