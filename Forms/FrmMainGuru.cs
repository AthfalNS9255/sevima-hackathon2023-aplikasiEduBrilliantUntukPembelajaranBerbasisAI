using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using EduBrilliant.UserControls;

namespace EduBrilliant
{
   public partial class FrmMainGuru : Form
   {
      SqlConnection cn;
      SqlCommand cmd;
      SqlDataReader dr;
      DataTable table;

      string formState;

      public FrmMainGuru()
      {
         InitializeComponent();
      }

		private void DefaultState()
		{
			btnDashboard.Checked = false;
			btnKelas.Checked = false;
			btnTransaksi.Checked = false;
			btnKategori.Checked = false;
		}

		public void Navigation(UserControl uc, Guna2Button btn)
		{
			DefaultState();
			btn.Checked = true;

			PnlContainer.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			PnlContainer.Controls.Add(uc);
			uc.BringToFront();
		}

		private void btnGuru_Click(object sender, EventArgs e)
		{
			UCGuru uc = new UCGuru();
			Navigation(uc, (Guna2Button)sender);
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			UCDashboardAdmin uc = new UCDashboardAdmin();
			Navigation(uc, (Guna2Button)sender);
		}

		private void btnSiswa_Click(object sender, EventArgs e)
		{
			UCSiswa uc = new UCSiswa();
			Navigation(uc, (Guna2Button)sender);
		}

		private void btnKategori_Click(object sender, EventArgs e)
		{
			UCKategori uc = new UCKategori();
			Navigation(uc, (Guna2Button)sender);
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			FrmLogin frm = new FrmLogin();
			frm.Show();
			Hide();
		}

		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
