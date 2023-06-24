using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduBrilliant.UserControls
{
	public partial class UCDashboardAdmin : UserControl
	{
		EduBrilliantEntities db = new EduBrilliantEntities();
		public UCDashboardAdmin()
		{
			InitializeComponent();
		}

		private void UCDashboardAdmin_Load(object sender, EventArgs e)
		{
			int Step = 0;
			try
			{
				int GuruCount = db.Users.Where(x => x.Role == "Guru").Count();
				lblGuru.Text = GuruCount.ToString();

				int SiswaCount = db.Users.Where(x => x.Role == "Siswa").Count();
				lblSiswa.Text = SiswaCount.ToString();

				int KategoriCount = db.Kategoris.Count();
				lblKategori.Text = KategoriCount.ToString();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error Load Step {Step} = {ex.Message}");
			}
		}

		private void guna2ShadowPanel1_Click(object sender, EventArgs e)
		{
			FrmMainAdmin frm = new FrmMainAdmin();
			UCGuru uc = new UCGuru();
			frm.Navigation(uc, frm.btnGuru);
		}

		private void guna2ShadowPanel2_Click(object sender, EventArgs e)
		{
			FrmMainAdmin frm = new FrmMainAdmin();
			UCSiswa uc = new UCSiswa();
			frm.Navigation(uc, frm.btnSiswa);
		}

		private void guna2ShadowPanel3_Click(object sender, EventArgs e)
		{
			FrmMainAdmin frm = new FrmMainAdmin();
			UCKategori uc = new UCKategori();
			frm.Navigation(uc, frm.btnKategori);
		}
	}
}
