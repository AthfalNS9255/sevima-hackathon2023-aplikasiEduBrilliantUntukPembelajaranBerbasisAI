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
	public partial class UCDashboardGuru : UserControl
	{
		EduBrilliantEntities db = new EduBrilliantEntities();
		public UCDashboardGuru()
		{
			InitializeComponent();
		}

		private void UCDashboardGuru_Load(object sender, EventArgs e)
		{
			int Step = 0;
			try
			{
				int KelasCount = db.Transaksis.Where(x => x.UserID == Session.UserID).GroupBy(x => x.KelasID).Count();
				lblKelas.Text = KelasCount.ToString();

				int TransaksiCount = db.Transaksis.Where(x => x.UserID == Session.UserID).Count();
				lblTransaksi.Text = TransaksiCount.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error Load Step {Step} = {ex.Message}");
			}
		}

		//private void guna2ShadowPanel1_Click(object sender, EventArgs e)
		//{
		//	FrmMainAdmin frm = new FrmMainAdmin();
		//	UCGuru uc = new UCGuru();
		//	frm.Navigation(uc, frm.btnGuru);
		//}

		//private void guna2ShadowPanel2_Click(object sender, EventArgs e)
		//{
		//	FrmMainAdmin frm = new FrmMainAdmin();
		//	UCSiswa uc = new UCSiswa();
		//	frm.Navigation(uc, frm.btnSiswa);
		//}

		//private void guna2ShadowPanel3_Click(object sender, EventArgs e)
		//{
		//	FrmMainAdmin frm = new FrmMainAdmin();
		//	UCKategori uc = new UCKategori();
		//	frm.Navigation(uc, frm.btnKategori);
		//}
	}
}
