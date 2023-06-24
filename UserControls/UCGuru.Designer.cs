namespace EduBrilliant.UserControls
{
	partial class UCGuru
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
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label namaLengkapLabel;
			System.Windows.Forms.Label noTelpLabel;
			System.Windows.Forms.Label passwordLabel;
			System.Windows.Forms.Label usernameLabel;
			System.Windows.Forms.Label label1;
			this.GuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.noTelpTextBox = new System.Windows.Forms.TextBox();
			this.namaLengkapTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			emailLabel = new System.Windows.Forms.Label();
			namaLengkapLabel = new System.Windows.Forms.Label();
			noTelpLabel = new System.Windows.Forms.Label();
			passwordLabel = new System.Windows.Forms.Label();
			usernameLabel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GuruBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// GuruBindingSource
			// 
			this.GuruBindingSource.DataSource = typeof(EduBrilliant.User);
			this.GuruBindingSource.Filter = "Role = \'Guru\'";
			// 
			// userDataGridView
			// 
			this.userDataGridView.AllowUserToAddRows = false;
			this.userDataGridView.AllowUserToDeleteRows = false;
			this.userDataGridView.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
			this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.userDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userDataGridView.AutoGenerateColumns = false;
			this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.userDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.userDataGridView.DataSource = this.GuruBindingSource;
			this.userDataGridView.Location = new System.Drawing.Point(3, 3);
			this.userDataGridView.Name = "userDataGridView";
			this.userDataGridView.ReadOnly = true;
			this.userDataGridView.RowHeadersVisible = false;
			this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.userDataGridView.Size = new System.Drawing.Size(669, 280);
			this.userDataGridView.TabIndex = 0;
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
			this.dataGridViewTextBoxColumn2.HeaderText = "NamaLengkap";
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
			// emailLabel
			// 
			emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			emailLabel.AutoSize = true;
			emailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			emailLabel.Location = new System.Drawing.Point(60, 330);
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
			namaLengkapLabel.Location = new System.Drawing.Point(60, 407);
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
			noTelpLabel.Location = new System.Drawing.Point(60, 444);
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
			passwordLabel.Location = new System.Drawing.Point(60, 481);
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
			usernameLabel.Location = new System.Drawing.Point(60, 370);
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
			label1.Location = new System.Drawing.Point(60, 518);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(123, 19);
			label1.TabIndex = 15;
			label1.Text = "Confirm Password:";
			// 
			// guna2Button1
			// 
			this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Button1.BorderRadius = 3;
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.White;
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.Black;
			this.guna2Button1.Location = new System.Drawing.Point(495, 346);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(104, 28);
			this.guna2Button1.TabIndex = 17;
			this.guna2Button1.Text = "Insert";
			// 
			// guna2Button2
			// 
			this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Button2.BorderRadius = 3;
			this.guna2Button2.BorderThickness = 1;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.FillColor = System.Drawing.Color.White;
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button2.ForeColor = System.Drawing.Color.Black;
			this.guna2Button2.Location = new System.Drawing.Point(495, 392);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(104, 28);
			this.guna2Button2.TabIndex = 18;
			this.guna2Button2.Text = "Update";
			// 
			// guna2Button3
			// 
			this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Button3.BorderRadius = 3;
			this.guna2Button3.BorderThickness = 1;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button3.FillColor = System.Drawing.Color.White;
			this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button3.ForeColor = System.Drawing.Color.Black;
			this.guna2Button3.Location = new System.Drawing.Point(495, 438);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new System.Drawing.Size(104, 28);
			this.guna2Button3.TabIndex = 19;
			this.guna2Button3.Text = "Delete";
			// 
			// guna2Button4
			// 
			this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Button4.BorderRadius = 3;
			this.guna2Button4.BorderThickness = 1;
			this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button4.FillColor = System.Drawing.Color.CornflowerBlue;
			this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button4.ForeColor = System.Drawing.Color.White;
			this.guna2Button4.Location = new System.Drawing.Point(441, 487);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new System.Drawing.Size(104, 28);
			this.guna2Button4.TabIndex = 20;
			this.guna2Button4.Text = "Save";
			// 
			// guna2Button5
			// 
			this.guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Button5.BorderRadius = 3;
			this.guna2Button5.BorderThickness = 1;
			this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button5.FillColor = System.Drawing.Color.OrangeRed;
			this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button5.ForeColor = System.Drawing.Color.White;
			this.guna2Button5.Location = new System.Drawing.Point(551, 487);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new System.Drawing.Size(104, 28);
			this.guna2Button5.TabIndex = 21;
			this.guna2Button5.Text = "Cancel";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuruBindingSource, "Username", true));
			this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.Location = new System.Drawing.Point(191, 367);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(6);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(221, 25);
			this.usernameTextBox.TabIndex = 14;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.Location = new System.Drawing.Point(191, 478);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(221, 25);
			this.passwordTextBox.TabIndex = 10;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// noTelpTextBox
			// 
			this.noTelpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.noTelpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuruBindingSource, "NoTelp", true));
			this.noTelpTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noTelpTextBox.Location = new System.Drawing.Point(191, 441);
			this.noTelpTextBox.Margin = new System.Windows.Forms.Padding(6);
			this.noTelpTextBox.Name = "noTelpTextBox";
			this.noTelpTextBox.Size = new System.Drawing.Size(221, 25);
			this.noTelpTextBox.TabIndex = 8;
			// 
			// namaLengkapTextBox
			// 
			this.namaLengkapTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.namaLengkapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuruBindingSource, "NamaLengkap", true));
			this.namaLengkapTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.namaLengkapTextBox.Location = new System.Drawing.Point(191, 404);
			this.namaLengkapTextBox.Margin = new System.Windows.Forms.Padding(6);
			this.namaLengkapTextBox.Name = "namaLengkapTextBox";
			this.namaLengkapTextBox.Size = new System.Drawing.Size(221, 25);
			this.namaLengkapTextBox.TabIndex = 6;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuruBindingSource, "Email", true));
			this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTextBox.Location = new System.Drawing.Point(191, 330);
			this.emailTextBox.Margin = new System.Windows.Forms.Padding(6);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(221, 25);
			this.emailTextBox.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(191, 515);
			this.textBox1.Margin = new System.Windows.Forms.Padding(6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(221, 25);
			this.textBox1.TabIndex = 16;
			this.textBox1.UseSystemPasswordChar = true;
			// 
			// UCGuru
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.guna2Button5);
			this.Controls.Add(this.guna2Button4);
			this.Controls.Add(this.guna2Button3);
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(emailLabel);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(namaLengkapLabel);
			this.Controls.Add(this.namaLengkapTextBox);
			this.Controls.Add(noTelpLabel);
			this.Controls.Add(this.noTelpTextBox);
			this.Controls.Add(passwordLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(usernameLabel);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.userDataGridView);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UCGuru";
			this.Size = new System.Drawing.Size(675, 579);
			this.Load += new System.EventHandler(this.UCGuru_Load);
			((System.ComponentModel.ISupportInitialize)(this.GuruBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource GuruBindingSource;
		private System.Windows.Forms.DataGridView userDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
		private Guna.UI2.WinForms.Guna2Button guna2Button4;
		private Guna.UI2.WinForms.Guna2Button guna2Button5;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox noTelpTextBox;
		private System.Windows.Forms.TextBox namaLengkapTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox textBox1;
	}
}
