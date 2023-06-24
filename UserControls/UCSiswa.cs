using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduBrilliant.UserControls
{
	public partial class UCSiswa : UserControl
	{
		EduBrilliantEntities db = new EduBrilliantEntities();

		string formstate = "";
		public UCSiswa()
		{
			InitializeComponent();
		}

		private void UCGuru_Load(object sender, EventArgs e)
		{
			GuruBindingSource.DataSource = db.Users.Where(x => x.Role == "Siswa").ToList();
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			btnInsert.Enabled = false;
			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

			btnSave.Enabled = true;
			btnCancel.Enabled = true;

			dgvGuru.ClearSelection();
			foreach (var item in Controls.OfType<TextBox>().ToList())
			{
				item.ResetText();
				item.Enabled = true;
			}

			formstate = "Insert";
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			btnInsert.Enabled = false;
			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

			btnSave.Enabled = true;
			btnCancel.Enabled = true;

			foreach (var item in Controls.OfType<TextBox>().ToList())
				item.Enabled = true;


			formstate = "Update";
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int Step = 0;
			try
			{
				if (txtEmail.Text.IsNullOrEmpty() || txtNamaLengkap.Text.IsNullOrEmpty() || txtNoTelp.Text.IsNullOrEmpty() || txtPassword.Text.IsNullOrEmpty() || txtConfirmPassword.Text.IsNullOrEmpty())
				{
					MessageBox.Show($"Isi semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.OK)
				{
					int rowindex = dgvGuru.CurrentRow.Index;
					int ID = dgvGuru.Rows[rowindex].Cells[0].Value.ToInt32();

					User user = db.Users.Where(x => x.ID == ID).First();
					db.Users.Remove(user);
					db.SaveChanges();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error Step {Step} = {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int Step = 0;
			try
			{
				if (txtEmail.Text.IsNullOrEmpty() || txtNamaLengkap.Text.IsNullOrEmpty() || txtNoTelp.Text.IsNullOrEmpty() || txtPassword.Text.IsNullOrEmpty() || txtConfirmPassword.Text.IsNullOrEmpty())
				{
					MessageBox.Show($"Isi semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!txtEmail.Text.IsValidEmail())
				{
					MessageBox.Show("Format Email salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (txtPassword.Text != txtConfirmPassword.Text)
				{
					MessageBox.Show("Password harus sama dengan Confirm Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if ((!txtNoTelp.Text.StartsWith("+62") && !txtNoTelp.Text.StartsWith("08")) || txtNoTelp.Text.Length < 10 || txtNoTelp.Text.Length > 14)
				{
					MessageBox.Show("Format nomor telepon salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				string Password = txtPassword.Text.Trim();

				SHA256 sha = SHA256.Create();
				byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(Password));

				StringBuilder sb = new StringBuilder();

				for (int i = 0; i < bytes.Length; i++)
				{
					sb.Append(bytes[i].ToString("x2"));
				}

				string HashPassword = sb.ToString();

				if (formstate == "Insert")
				{
					User user = new User();
					user.Email = txtEmail.Text.Trim();
					user.NamaLengkap = txtNamaLengkap.Text.Trim();
					user.Username = txtUsername.Text.Trim();
					user.NoTelp = txtNoTelp.Text.Trim();
					user.Password = HashPassword;
					user.Role = "Siswa";

					db.Users.Add(user);
					db.SaveChanges();

				}
				else if (formstate == "Update")
				{
					int rowindex = dgvGuru.CurrentRow.Index;
					int ID = dgvGuru.Rows[rowindex].Cells[0].Value.ToInt32();

					User user = db.Users.Where(x => x.ID == ID).First();
					user.Email = txtEmail.Text.Trim();
					user.NamaLengkap = txtNamaLengkap.Text.Trim();
					user.Username = txtUsername.Text.Trim();
					user.NoTelp = txtNoTelp.Text.Trim();
					user.Password = HashPassword;
					user.Role = "Siswa";
					db.Entry(user).State = System.Data.Entity.EntityState.Modified;
					db.SaveChanges();
				}

				btnInsert.Enabled = true;
				btnUpdate.Enabled = true;
				btnDelete.Enabled = true;

				btnSave.Enabled = false;
				btnCancel.Enabled = false;

				foreach (var item in Controls.OfType<TextBox>().ToList())
				{
					item.ResetText();
					item.Enabled = true;
				}

				GuruBindingSource.DataSource = db.Users.Where(x => x.Role == "Siswa").ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error Step {Step} = {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			btnInsert.Enabled = true;
			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;

			btnSave.Enabled = false;
			btnCancel.Enabled = false;

			foreach (var item in Controls.OfType<TextBox>().ToList())
			{
				item.ResetText();
				item.Enabled = true;
			}
		}
	}
}