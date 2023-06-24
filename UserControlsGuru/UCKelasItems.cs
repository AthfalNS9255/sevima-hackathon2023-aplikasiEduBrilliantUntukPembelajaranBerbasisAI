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
	public partial class UCKelasItems : UserControl
	{
		public UCKelasItems()
		{
			InitializeComponent();
		}

		public string Nama
		{
			get { return lblNama.Text.Trim(); }
			set { lblNama.Text = value.ToString(); }
		}

		public string Kategori
		{
			get { return lblKategori.Text.Trim(); }
			set { lblKategori.Text = value.ToString(); }
		}

		public string Harga
		{
			get { return lblHarga.Text.Trim(); }
			set { lblHarga.Text = value.ToString(); }
		}

		public int ID
		{
			get { return lblID.Text.GetAfter("ID : ").Trim().ToInt32(); }
			set { lblID.Text = $"ID : {value}"; }
		}

		private void btnDetail_Click(object sender, EventArgs e)
		{
			//FrmMainGuru frm = new FrmMainGuru();
			//frm.PnlContainer.Controls.Add();
		}
	}
}
