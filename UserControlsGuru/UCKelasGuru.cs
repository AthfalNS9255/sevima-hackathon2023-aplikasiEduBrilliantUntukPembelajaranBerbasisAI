using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduBrilliant.UserControlsGuru
{
	public partial class UCKelasGuru : UserControl
	{
		EduBrilliantEntities db = new EduBrilliantEntities();

		public UCKelasGuru()
		{
			InitializeComponent();
		}

		private void UCKelasGuru_Load(object sender, EventArgs e)
		{
			cbKategoriBindingSource.DataSource = db.Kategoris.ToList();
			FlowLayoutLoad();
		}

		private void FlowLayoutLoad()
		{
			int Step = 0;
			try
			{
				flowPanelKelas.Controls.Clear();

				List<Kela> lstKelas = db.Kelas.ToList();

				foreach (var item in lstKelas)
				{
					flowPanelKelas.Controls.Add(new UCKelasItems
					{
						ID = item.ID,
						Nama = item.Nama,
						Harga = "Rp. " + item.Harga.ToString("N2"),
						Kategori = item.Kategori.Nama
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error Step {Step} = {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnTambah_Click(object sender, EventArgs e)
		{
			int Step = 0;
			try
			{
				if (txtNama.Text.IsNullOrEmpty() || cbKategori.Text.IsNullOrEmpty())
				{
					MessageBox.Show($"Isi semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Step = 1;

				Kela kelas = new Kela();
				kelas.Nama = txtNama.Text.Trim();
				kelas.KategoriID = cbKategori.SelectedValue.ToInt32();
				kelas.Harga = (int)numHarga.Value;
				db.Kelas.Add(kelas);

				if (db.SaveChanges() == 1)
				{
					flowPanelKelas.Controls.Add(new UCKelasItems
					{
						ID = kelas.ID,
						Nama = kelas.Nama,
						Harga = "Rp. " + kelas.Harga.ToString("N2"),
						Kategori = cbKategori.Text
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error Step {Step} = {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
