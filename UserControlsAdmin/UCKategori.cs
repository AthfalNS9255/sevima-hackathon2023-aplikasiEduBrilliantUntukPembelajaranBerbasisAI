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
	public partial class UCKategori : UserControl
	{
		EduBrilliantEntities db = new EduBrilliantEntities();

		string formstate = "";
		public UCKategori()
		{
			InitializeComponent();
		}

		private void UCKategori_Load(object sender, EventArgs e)
		{
			KategoriBindingSource.DataSource = db.Kategoris.ToList();
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			btnInsert.Enabled = false;
			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

			btnSave.Enabled = true;
			btnCancel.Enabled = true;

			dgvKategori.ClearSelection();
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
				if (txtNama.Text.IsNullOrEmpty())
				{
					MessageBox.Show($"Isi semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.OK)
				{
					int rowindex = dgvKategori.CurrentRow.Index;
					int ID = dgvKategori.Rows[rowindex].Cells[0].Value.ToInt32();

					Kategori kategori = db.Kategoris.Where(x => x.ID == ID).First();
					db.Kategoris.Remove(kategori);
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
				if (txtNama.Text.IsNullOrEmpty())
				{
					MessageBox.Show($"Isi semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (formstate == "Insert")
				{
					Kategori kategori = new Kategori();
					kategori.Nama = txtNama.Text.Trim();

					db.Kategoris.Add(kategori);
					db.SaveChanges();

				}
				else if (formstate == "Update")
				{
					int rowindex = dgvKategori.CurrentRow.Index;
					int ID = dgvKategori.Rows[rowindex].Cells[0].Value.ToInt32();

					Kategori kategori = db.Kategoris.Where(x => x.ID == ID).First();
					kategori.Nama = txtNama.Text.Trim();

					db.Entry(kategori).State = System.Data.Entity.EntityState.Modified;
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

				KategoriBindingSource.DataSource = db.Kategoris.ToList();
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