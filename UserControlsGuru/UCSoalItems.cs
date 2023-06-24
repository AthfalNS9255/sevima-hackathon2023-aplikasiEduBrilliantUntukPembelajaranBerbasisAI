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
	public partial class UCSoalItems : UserControl
	{
		public UCSoalItems()
		{
			InitializeComponent();
		}

		public string Nomor
		{
			get { return lblNo.Text.GetAfter("No. : ").Trim(); }
			set { lblNo.Text = "No. : " + value.ToString(); }
		}

		public string Jawaban
		{
			get { return lblJawaban.Text.GetAfter("Jawaban : ").Trim(); }
			set { lblJawaban.Text = "Jawaban : " + value.ToString(); }
		}

		public string Soal
		{
			get { return txtSoal.Text.Trim(); }
			set { txtSoal.Text = value.ToString(); }
		}

		public int ID
		{
			get { return lblID.Text.Trim().ToInt32(); }
			set { lblID.Text = value.ToString(); }
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
