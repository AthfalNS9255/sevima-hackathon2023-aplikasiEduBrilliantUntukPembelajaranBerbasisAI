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

namespace EduBrilliant
{
   public partial class FrmMainAdmin : Form
   {
      SqlConnection cn;
      SqlCommand cmd;
      SqlDataReader dr;
      DataTable table;

      string formState;

      public FrmMainAdmin()
      {
         InitializeComponent();
      }

      private void FrmMainAdmin_Load(object sender, EventArgs e)
      {
         cn = new SqlConnection(@"Server=localhost;Database=silelangonline;Uid=root;Pwd=root;Convert Zero datetime=true;");
         cn.Open();

         DasboardLoad();
      }

      private void DefaultState()
      {
         pnlBarang.Visible = false;
         btnBarang.FillColor = Color.Transparent;

         pnlDashboard.Visible = false;
         btnDashboard.FillColor = Color.Transparent;

         pnlLelang.Visible = false;
         btnLelang.FillColor = Color.Transparent;

         pnlPetugas.Visible = false;
         btnPetugas.FillColor = Color.Transparent;
      }

      private void btnLogOut_Click(object sender, EventArgs e)
      {
         Hide();
         FrmLogin frmLogin = new FrmLogin();
         frmLogin.Show();
      }

      #region Dashboard

      private void btnDashboard_Click(object sender, EventArgs e)
      {
         DefaultState();
         DasboardLoad();
         pnlDashboard.Visible = true;
         btnDashboard.FillColor = Color.FromArgb(87, 89, 89);
      }

      private void DasboardLoad()
      {
         int Step = 0;
         try
         {
            cmd = new SqlCommand("select count(*) from tb_barang", cn);
            int Barang = cmd.ExecuteScalar().ToInt32();
            lblDashboardBarang.Text = Barang.ToString();

            cmd = new SqlCommand("select count(*) from tb_lelang", cn);
            int Lelang = cmd.ExecuteScalar().ToInt32();
            lblDashboardLelang.Text = Lelang.ToString();

            cmd = new SqlCommand("select count(*) from tb_petugas", cn);
            int Petugas = cmd.ExecuteScalar().ToInt32();
            lblDashboardPetugas.Text = Petugas.ToString();
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Load Step {Step} = {ex.Message}");
         }
      }

      #endregion

      #region Barang

      private void btnBarang_Click(object sender, EventArgs e)
      {
         DefaultState();
         pnlBarang.Visible = true;
         btnBarang.FillColor = Color.FromArgb(87, 89, 89);

         tblBarangLoad();
      }

      private void btnNewBarang_Click(object sender, EventArgs e)
      {
         formState = "New Barang";

         lblDialogBarang.Text = "New Barang";
         btnDeleteBarang.Visible = false;

         dtTanggalBarang.Value = DateTime.Now;

         pnlDialogBarang.Visible = true;
         pnlDialogBarang.BringToFront();
      }

      private void btnBackDialogBarang_Click(object sender, EventArgs e)
      {
         string ID = txtIDBarang.Text.Trim();
         string Nama = txtNamaBarang.Text.Trim();
         string Tanggal = dtTanggalBarang.Value.ToString("dd/MM/yyyy");
         string HargaAwal = txtHargaAwalBarang.Text.Replace(".", "").Trim();
         string Deskripsi = txtDeskripsiBarang.Text.Trim();

         if (Nama.IsNotNullOrEmpty() || HargaAwal.IsNotNullOrEmpty() || Deskripsi.IsNotNullOrEmpty())
         {
            DialogResult dr = MessageBox.Show("Anda mempunyai data yang belum disimpan. Yakin ingin keluar?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
               pnlDialogBarang.Visible = false;
            }
         }
         else
         {
            pnlDialogBarang.Visible = false;
         }

         txtIDBarang.ResetText();
         txtNamaBarang.ResetText();
         dtTanggalBarang.Value = DateTime.Now;
         txtHargaAwalBarang.ResetText();
         txtDeskripsiBarang.ResetText();
      }

      private void btnSaveBarang_Click(object sender, EventArgs e)
      {
         int Step = 0;
         try
         {
            Step = 1;
            string ID = txtIDBarang.Text.Trim();
            string Nama = txtNamaBarang.Text.Trim();
            string Tanggal = dtTanggalBarang.Value.ToString("yyyy-MM-dd");
            string HargaAwal = txtHargaAwalBarang.Text.Replace(".", "").Trim();
            string Deskripsi = txtDeskripsiBarang.Text.Trim();

            Step = 2;
            if (!HargaAwal.IsValidInt64())
            {
               MessageBox.Show("field harga harus angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            if (Nama.IsNotNullOrEmpty() && Tanggal.IsNotNullOrEmpty() && HargaAwal.IsNotNullOrEmpty() && Deskripsi.IsNotNullOrEmpty())
            {
               if (formState == "New Barang")
               {
                  cmd = new SqlCommand($"insert into tb_barang (nama_barang, tgl, harga_awal, deskripsi_barang) values " +
                  $"('{Nama}', '{Tanggal}', '{HargaAwal}', '{Deskripsi}')", cn);
                  cmd.ExecuteNonQuery();

                  MessageBox.Show("Berhasil menambah barang!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else if (formState == "Edit Barang")
               {
                  cmd = new SqlCommand($"update tb_barang set nama_barang = '{Nama}', tgl = '{Tanggal}', harga_awal = '{HargaAwal}', " +
                     $"deskripsi_barang = '{Deskripsi}' where id_barang = {ID}", cn);
                  cmd.ExecuteNonQuery();

                  MessageBox.Show("Berhasil mengedit barang!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

               txtIDBarang.ResetText();
               txtNamaBarang.ResetText();
               dtTanggalBarang.Value = DateTime.Now;
               txtHargaAwalBarang.ResetText();
               txtDeskripsiBarang.ResetText();

               tblBarangLoad();
               pnlDialogBarang.Visible = false;
            }
            else
            {
               MessageBox.Show("Isi semua field terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Save Step {Step} = {ex.Message}");
         }
      }

      private void btnDeleteBarang_Click(object sender, EventArgs e)
      {
         int Step = 0;
         try
         {
            DialogResult dialogResult = MessageBox.Show("Anda yakin ingin Menghapus?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
               return;
            }

            Step = 1;
            string ID = txtIDBarang.Text.Trim();
            string Nama = txtNamaBarang.Text.Trim();
            string Tanggal = dtTanggalBarang.Value.ToString("dd/MM/yyyy");
            string HargaAwal = txtHargaAwalBarang.Text.Replace(".", "").Trim();
            string Deskripsi = txtDeskripsiBarang.Text.Trim();

            Step = 2;
            if (!HargaAwal.IsValidInt64())
            {
               MessageBox.Show("field harga harus angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            if (Nama.IsNotNullOrEmpty() && Tanggal.IsNotNullOrEmpty() && HargaAwal.IsNotNullOrEmpty() && Deskripsi.IsNotNullOrEmpty())
            {
               cmd = new SqlCommand($"delete from tb_barang where id_barang = {ID}", cn);
               cmd.ExecuteNonQuery();

               MessageBox.Show("Berhasil menghapus barang!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               txtIDBarang.ResetText();
               txtNamaBarang.ResetText();
               dtTanggalBarang.Value = DateTime.Now;
               txtHargaAwalBarang.ResetText();
               txtDeskripsiBarang.ResetText();

               tblBarangLoad();
               pnlDialogBarang.Visible = false;
            }
            else
            {
               MessageBox.Show("Isi semua field terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Delete Step {Step} = {ex.Message}");
         }
      }

      private void btnRefreshBarang_Click(object sender, EventArgs e)
      {
         if (!txtFilterTanggalBarang.Text.IsValidDateTime() && txtFilterTanggalBarang.Text.IsNotNullOrEmpty())
         {
            MessageBox.Show("Format filter tanggal salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         tblBarangLoad();
      }

      private void btnSearchBarang_Click(object sender, EventArgs e)
      {
         tblBarangLoad();
      }

      private void tblBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         if (tblBarang.Columns[e.ColumnIndex].Name == "btnEditBarang")
         {
            int rowindex = tblBarang.CurrentRow.Index;

            txtIDBarang.Text = tblBarang.Rows[rowindex].Cells["ID"].Value.ToString();
            txtNamaBarang.Text = tblBarang.Rows[rowindex].Cells["Nama"].Value.ToString();
            dtTanggalBarang.Value = tblBarang.Rows[rowindex].Cells["Tanggal"].Value.ToDateTime();
            txtHargaAwalBarang.Text = tblBarang.Rows[rowindex].Cells["Harga_Awal"].Value.ToString();
            txtDeskripsiBarang.Text = tblBarang.Rows[rowindex].Cells["Deskripsi"].Value.ToString();

            formState = "Edit Barang";

            lblDialogBarang.Text = $"Edit Barang({txtNamaBarang.Text})";
            btnDeleteBarang.Visible = true;

            pnlDialogBarang.Visible = true;
            pnlDialogBarang.BringToFront();
         }
      }

      private void tblBarangLoad()
      {
         int Step = 0;
         table = new DataTable();
         try
         {
            Step = 1;
            cmd = new SqlCommand($"Select id_barang as ID, nama_barang as Nama, tgl as Tanggal, harga_awal as Harga_Awal, " +
               $"deskripsi_barang as Deskripsi FROM tb_barang where nama_barang like '%{txtSearchBarang.Text}%'", cn);
            table.Load(cmd.ExecuteReader());
            
            Step = 2;
            if (txtFilterTanggalBarang.Text.IsNotNullOrEmpty())
            {
               table.DefaultView.RowFilter = $"Tanggal = '{txtFilterTanggalBarang.Text}'";
            }

            tblBarang.DataSource = table;

            Step = 3;
            DataGridViewButtonColumn btnEditBarang = new DataGridViewButtonColumn
            {
               UseColumnTextForButtonValue = true,
               Name = "btnEditBarang",
               HeaderText = "Edit",
               Text = "Edit",
               DefaultCellStyle = new DataGridViewCellStyle
               {
                  Alignment = DataGridViewContentAlignment.MiddleCenter
               }
            };
            
            Step = 4;
            tblBarang.Columns.Add(btnEditBarang);
            if (tblBarang.Columns.Count == 7)
            {
               tblBarang.Columns.RemoveAt(6);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Load Step {Step} = {ex.Message}");
         }
      }

      #endregion

      #region Petugas

      private void btnPetugas_Click(object sender, EventArgs e)
      {
         DefaultState();
         pnlPetugas.Visible = true;
         btnPetugas.FillColor = Color.FromArgb(87, 89, 89);

         tblPetugasLoad();
      }

      private void btnNewPetugas_Click(object sender, EventArgs e)
      {
         formState = "New Petugas";

         lblDialogPetugas.Text = "New Petugas";
         btnDeletePetugas.Visible = false;

         pnlDialogPetugas.Visible = true;
         pnlDialogPetugas.BringToFront();
      }

      private void btnRefreshPetugas_Click(object sender, EventArgs e)
      {
         tblBarangLoad();
      }

      private void btnSearchPetugas_Click(object sender, EventArgs e)
      {
         tblBarangLoad();
      }

      private void btnBackDialogPetugas_Click(object sender, EventArgs e)
      {
         string ID = txtIDPetugas.Text.Trim();
         string Nama = txtNamaPetugas.Text.Trim();
         string Username = txtUsernamePetugas.Text.Trim();
         string Password = txtPasswordPetugas.Text.Trim();
         string ConfirmPasssword = txtConfirmPasswordPetugas.Text.Trim();

         if (Nama.IsNotNullOrEmpty() || Username.IsNotNullOrEmpty() || Password.IsNotNullOrEmpty() || ConfirmPasssword.IsNotNullOrEmpty())
         {
            DialogResult dr = MessageBox.Show("Anda mempunyai data yang belum disimpan. Yakin ingin keluar?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
               pnlDialogPetugas.Visible = false;
            }
         }
         else
         {
            pnlDialogPetugas.Visible = false;
         }

         txtIDPetugas.ResetText();
         txtNamaPetugas.ResetText();
         txtUsernamePetugas.ResetText();
         txtPasswordPetugas.ResetText();
         txtConfirmPasswordPetugas.ResetText();
      }

      private void btnSavePetugas_Click(object sender, EventArgs e)
      {
         int Step = 0;
         try
         {
            Step = 1;
            string ID = txtIDPetugas.Text.Trim();
            string Nama = txtNamaPetugas.Text.Trim();
            string Username = txtUsernamePetugas.Text.Trim();
            string Password = txtPasswordPetugas.Text.Trim();
            string ConfirmPasssword = txtConfirmPasswordPetugas.Text.Trim();

            Step = 2;
            if (Password.IsNotNullOrEmpty() && Password.Length < 8)
            {
               MessageBox.Show("Password minimal 8 karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            if (Password.IsNotNullOrEmpty() && Password != ConfirmPasssword)
            {
               MessageBox.Show("Password harus sama dengan Confirm Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            SHA256 sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(Password));

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
               sb.Append(bytes[i].ToString("x2"));
            }

            string HashPassword = sb.ToString();

            if (formState == "New Petugas")
            {
               if (Nama.IsNotNullOrEmpty() && Username.IsNotNullOrEmpty() && Password.IsNotNullOrEmpty() && ConfirmPasssword.IsNotNullOrEmpty())
               {
                  cmd = new SqlCommand($"insert into tb_petugas (nama_petugas, username, password, id_level) values " +
                  $"('{Nama}', '{Username}', '{HashPassword}', 2)", cn);
                  cmd.ExecuteNonQuery();

                  MessageBox.Show("Berhasil menambah petugas!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                  MessageBox.Show("Isi semua field terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
            else if (formState == "Edit Petugas")
            {
               if (Nama.IsNotNullOrEmpty() && Username.IsNotNullOrEmpty())
               {
                  cmd = new SqlCommand($"update tb_petugas set nama_petugas = '{Nama}', username = '{Username}' where id_petugas = {ID}", cn);
                  cmd.ExecuteNonQuery();

                  if (Password.IsNotNullOrEmpty() && ConfirmPasssword.IsNotNullOrEmpty())
                  {
                     cmd = new SqlCommand($"update tb_petugas set password = '{HashPassword}' where id_petugas = {ID}", cn);
                     cmd.ExecuteNonQuery();
                  }

                  MessageBox.Show("Berhasil mengedit petugas!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                  MessageBox.Show("Isi field Nama dan Username terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }

            txtIDPetugas.ResetText();
            txtNamaPetugas.ResetText();
            txtUsernamePetugas.ResetText();
            txtPasswordPetugas.ResetText();
            txtConfirmPasswordPetugas.ResetText();

            tblPetugasLoad();
            pnlDialogPetugas.Visible = false;
            
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Save Step {Step} = {ex.Message}");
         }
      }

      private void btnDeletePetugas_Click(object sender, EventArgs e)
      {
         int Step = 0;
         try
         {
            DialogResult dialogResult = MessageBox.Show("Anda yakin ingin Menghapus?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
               return;
            }

            Step = 1;
            string ID = txtIDPetugas.Text.Trim();
            string Nama = txtNamaPetugas.Text.Trim();
            string Username = txtUsernamePetugas.Text.Trim();
            string Password = txtPasswordPetugas.Text.Trim();
            string ConfirmPasssword = txtConfirmPasswordPetugas.Text.Trim();

            Step = 2;
            
            if (Nama.IsNotNullOrEmpty() && Username.IsNotNullOrEmpty())
            {
               cmd = new SqlCommand($"delete from tb_petugas where id_petugas = {ID}", cn);
               cmd.ExecuteNonQuery();

               MessageBox.Show("Berhasil menghapus petugas!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               txtIDPetugas.ResetText();
               txtNamaPetugas.ResetText();
               txtUsernamePetugas.ResetText();
               txtPasswordPetugas.ResetText();
               txtConfirmPasswordPetugas.ResetText();

               tblPetugasLoad();
               pnlDialogPetugas.Visible = false;
            }
            else
            {
               MessageBox.Show("Isi semua field terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Delete Step {Step} = {ex.Message}");
         }
      }

      private void tblPetugas_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         if (tblPetugas.Columns[e.ColumnIndex].Name == "btnEditPetugas")
         {
            int rowindex = tblPetugas.CurrentRow.Index;

            txtIDPetugas.Text = tblPetugas.Rows[rowindex].Cells["ID"].Value.ToString();
            txtNamaPetugas.Text = tblPetugas.Rows[rowindex].Cells["Nama"].Value.ToString();
            txtUsernamePetugas.Text = tblPetugas.Rows[rowindex].Cells["Username"].Value.ToString();

            formState = "Edit Petugas";

            lblDialogBarang.Text = $"Edit Petugas({txtNamaPetugas.Text})";
            btnDeletePetugas.Visible = true;

            pnlDialogPetugas.Visible = true;
            pnlDialogPetugas.BringToFront();
         }
      }

      private void tblPetugasLoad()
      {
         int Step = 0;
         table = new DataTable();
         try
         {
            Step = 1;
            cmd = new SqlCommand($"select tb_petugas.id_petugas as ID, tb_level.id_level as LevelID, nama_petugas as Nama, username as Username, tb_level.level as Level " +
               $"from tb_petugas join tb_level on tb_level.id_level = tb_petugas.id_level where nama_petugas like '%{txtSearchPetugas.Text}%' and tb_petugas.id_level = '2'", cn);
            table.Load(cmd.ExecuteReader());

            Step = 2;
            tblPetugas.DataSource = table;

            Step = 3;
            DataGridViewButtonColumn btnEditPetugas = new DataGridViewButtonColumn
            {
               UseColumnTextForButtonValue = true,
               Name = "btnEditPetugas",
               HeaderText = "Edit",
               Text = "Edit",
               DefaultCellStyle = new DataGridViewCellStyle
               {
                  Alignment = DataGridViewContentAlignment.MiddleCenter
               }
            };

            Step = 4;
            tblPetugas.Columns.Add(btnEditPetugas);
            if (tblPetugas.Columns.Count == 7)
            {
               tblPetugas.Columns.RemoveAt(6);
            }

            tblPetugas.Columns["LevelID"].Visible = false;
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Load Step {Step} = {ex.Message}");
         }
      }

      #endregion

      #region Lelang

      private void btnLelang_Click(object sender, EventArgs e)
      {
         DefaultState();
         pnlLelang.Visible = true;
         btnLelang.FillColor = Color.FromArgb(87, 89, 89);

         tblLelangLoad();
      }

      private void btnNewLelang_Click(object sender, EventArgs e)
      {
         formState = "New Lelang";

         lblDialogLelang.Text = "New Lelang";
         btnDeleteLelang.Visible = false;
         cbNamaBarangLelangLoad();

         txtHargaAkhirLelang.Text = "-";

         cbStatusLelang.Enabled = false;
         cbStatusLelang.Text = "Dibuka";
         dtTanggalLelang.Value = DateTime.Now;
         cbNamaBarangLelang.Enabled = true;

         pnlDialogLelang.Visible = true;
         pnlDialogLelang.BringToFront();
      }

      private void btnRefreshLelang_Click(object sender, EventArgs e)
      {
         if (!txtFilterTanggalLelang.Text.IsValidDateTime() && txtFilterTanggalLelang.Text.IsNotNullOrEmpty())
         {
            MessageBox.Show("Format filter tanggal salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         tblLelangLoad();
      }

      private void btnSearchLelang_Click(object sender, EventArgs e)
      {
         tblLelangLoad();
      }

      private void btnExportPDFLelang_Click(object sender, EventArgs e)
      {
         //if (tblLelang.Rows.Count > 0)
         //{
         //   SaveFileDialog sfd = new SaveFileDialog();
         //   sfd.Filter = "PDF (*.pdf)|*.pdf";
         //   sfd.FileName = $"Lelang_{DateTime.Now:ddMMyyyy}.pdf";
         //   bool fileError = false;
         //   if (sfd.ShowDialog() == DialogResult.OK)
         //   {
         //      if (File.Exists(sfd.FileName))
         //      {
         //         try
         //         {
         //            File.Delete(sfd.FileName);
         //         }
         //         catch (IOException ex)
         //         {
         //            fileError = true;
         //            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
         //         }
         //      }
         //      if (!fileError)
         //      {
         //         try
         //         {
         //            PdfPTable pdfTable = new PdfPTable(tblLelang.Columns.Count);
         //            pdfTable.DefaultCell.Padding = 3;
         //            pdfTable.WidthPercentage = 100;
         //            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

         //            foreach (DataGridViewColumn column in tblLelang.Columns)
         //            {
         //               PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
         //               pdfTable.AddCell(cell);
         //            }

         //            foreach (DataGridViewRow row in tblLelang.Rows)
         //            {
         //               foreach (DataGridViewCell cell in row.Cells)
         //               {
         //                  pdfTable.AddCell(cell.Value.ToString());
         //               }
         //            }

         //            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
         //            {
         //               Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
         //               PdfWriter.GetInstance(pdfDoc, stream);
         //               pdfDoc.Open();
         //               pdfDoc.Add(pdfTable);
         //               pdfDoc.Close();
         //               stream.Close();
         //            }

         //            MessageBox.Show("Data Exported Successfully !!!", "Info");
         //         }
         //         catch (Exception ex)
         //         {
         //            MessageBox.Show("Error :" + ex.Message);
         //         }
         //      }
         //   }
         //}
         //else
         //{
         //   MessageBox.Show("No Record To Export !!!", "Info");
         //}
      }

      private void btnExportExcelLelang_Click(object sender, EventArgs e)
      {
         //SaveFileDialog sfd = new SaveFileDialog();
         //sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
         //sfd.FileName = $"Lelang_{DateTime.Now:ddMMyyyy}.xlsx";
         //bool fileError = false;
         //if (sfd.ShowDialog() == DialogResult.OK)
         //{
         //   if (File.Exists(sfd.FileName))
         //   {
         //      try
         //      {
         //         File.Delete(sfd.FileName);
         //      }
         //      catch (IOException ex)
         //      {
         //         fileError = true;
         //         MessageBox.Show("It wasn't possible to write the data to the disk. " + ex.Message);
         //      }
         //   }
         //   if (!fileError)
         //   {
         //      table = new DataTable();
         //      int Step = 0;

         //      try
         //      {
         //         Step = 1;
         //         Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
         //         Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
         //         Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

         //         worksheet = workbook.Sheets["Sheet1"];
         //         worksheet = workbook.ActiveSheet;
         //         worksheet.Name = "Exported from SiLelangOnline";

         //         Step = 2;
         //         for (int i = 1; i < tblLelang.Columns.Count + 1; i++)
         //         {
         //            worksheet.Cells[1, i] = tblLelang.Columns[i - 1].HeaderText;
                     
         //         }
         //         // storing Each row and column value to excel sheet
         //         for (int i = 0; i < tblLelang.Rows.Count; i++)
         //         {
         //            for (int j = 0; j < tblLelang.Columns.Count; j++)
         //            {
         //               worksheet.Cells[i + 2, j + 1] = tblLelang.Rows[i].Cells[j].Value.ToString();
                        
         //            }
         //         }

         //         worksheet.Columns.AutoFit();

         //         app.Visible = false;

         //         workbook.SaveAs(sfd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
         //         // Exit from the application
         //         app.Quit();

         //         MessageBox.Show("Data Exported Successfully !!!", "Info");

         //      }
         //      catch (Exception ex)
         //      {
         //         MessageBox.Show($"Error Step {Step}: " + ex.Message);
         //      }
         //   }
         //}
      }

      private void btnBackLelang_Click(object sender, EventArgs e)
      {
         string ID = txtIDLelang.Text.Trim();
         string NamaBarang = cbNamaBarangLelang.Text.Trim();
         int IDBarang = cbNamaBarangLelang.SelectedValue.ToInt32();
         string Tanggal = dtTanggalLelang.Value.ToString("yyyy-MM-dd");
         string NamaPemenang = txtNamaPemenangLelang.Text.Trim();
         string HargaAkhir = txtHargaAkhirLelang.Text.Replace(".", "").Trim();
         string NamaPenjual = txtNamaPenjualLelang.Text.Trim();
         string Status = cbStatusLelang.Text.Trim();

         if (NamaBarang.IsNotNullOrEmpty() || HargaAkhir.IsNotNullOrEmpty() || Status.IsNotNullOrEmpty())
         {
            DialogResult dr = MessageBox.Show("Anda mempunyai data yang belum disimpan. Yakin ingin keluar?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
               pnlDialogLelang.Visible = false;
            }
         }
         else
         {
            pnlDialogPetugas.Visible = false;
         }

         txtIDLelang.ResetText();
         cbNamaBarangLelang.ResetText();
         dtTanggalLelang.Value = DateTime.Now;
         txtNamaPemenangLelang.ResetText();
         txtHargaAkhirLelang.ResetText();
         txtNamaPenjualLelang.ResetText();
         cbStatusLelang.ResetText();
      }

      private void btnSaveLelang_Click(object sender, EventArgs e)
      {
         int Step = 0;
         try
         {
            Step = 1;
            string ID = txtIDLelang.Text.Trim();
            string NamaBarang = cbNamaBarangLelang.Text.Trim();
            int IDBarang = cbNamaBarangLelang.SelectedValue.ToInt32();
            string Tanggal = dtTanggalLelang.Value.ToString("yyyy-MM-dd");
            string NamaPemenang = txtNamaPemenangLelang.Text.Trim();
            string HargaAkhir = txtHargaAkhirLelang.Text.Replace(".", "").Trim();
            string NamaPenjual = txtNamaPenjualLelang.Text.Trim();
            string Status = cbStatusLelang.Text.Trim();

            Step = 2;
            if (!HargaAkhir.IsValidInt64() && HargaAkhir != "-")
            {
               MessageBox.Show("field harga harus angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            if (NamaBarang.IsNotNullOrEmpty() && Tanggal.IsNotNullOrEmpty() && Status.IsNotNullOrEmpty())
            {
               if (formState == "New Lelang")
               {
                  cmd = new SqlCommand($"select id_lelang from tb_lelang where id_barang = '{IDBarang}'", cn);
                  dr = cmd.ExecuteReader();
                  if (dr.Read())
                  {
                     MessageBox.Show("Barang sudah di lelang!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     dr.Close();
                     return;
                  }
                  dr.Close();

                  cmd = new SqlCommand($"insert into tb_lelang (id_barang, tgl_lelang, status) values " +
                  $"('{IDBarang}', '{Tanggal}', '{Status}')", cn);
                  cmd.ExecuteNonQuery();

                  MessageBox.Show("Berhasil menambah lelang!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else if (formState == "Edit Lelang")
               {
                  cmd = new SqlCommand($"update tb_lelang set id_barang = '{IDBarang}', tgl_lelang = '{Tanggal}', " +
                     $"status = '{Status}' where id_lelang = {ID}", cn);
                  cmd.ExecuteNonQuery();

                  if (cbStatusLelang.Text == "Sold Out")
                  {
                     cmd = new SqlCommand($"update tb_lelang set id_petugas = {DataLogin.UserID} where id_lelang = {ID}", cn);
                     cmd.ExecuteNonQuery();
                  }

                  MessageBox.Show("Berhasil mengedit lelang!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

               txtIDLelang.ResetText();
               cbNamaBarangLelang.ResetText();
               dtTanggalLelang.Value = DateTime.Now;
               txtNamaPemenangLelang.ResetText();
               txtHargaAkhirLelang.ResetText();
               txtNamaPenjualLelang.ResetText();
               cbStatusLelang.ResetText();

               tblLelangLoad();
               pnlDialogLelang.Visible = false;
            }
            else
            {
               MessageBox.Show("Isi semua field terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Save Step {Step} = {ex.Message}");
         }
      }

      private void btnDeleteLelang_Click(object sender, EventArgs e)
      {
         int Step = 0;
         try
         {
            DialogResult dialogResult = MessageBox.Show("Anda yakin ingin Menghapus?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
               return;
            }

            Step = 1;
            string ID = txtIDLelang.Text.Trim();
            string NamaBarang = cbNamaBarangLelang.Text.Trim();
            int IDBarang = cbNamaBarangLelang.SelectedValue.ToInt32();
            string Tanggal = dtTanggalLelang.Value.ToString("yyyy-MM-dd");
            string NamaPemenang = txtNamaPemenangLelang.Text.Trim();
            string HargaAkhir = txtHargaAkhirLelang.Text.Replace(".", "").Trim();
            string NamaPenjual = txtNamaPenjualLelang.Text.Trim();
            string Status = cbStatusLelang.Text.Trim();

            Step = 2;
            if (!HargaAkhir.IsValidInt64() && HargaAkhir != "-")
            {
               MessageBox.Show("field harga harus angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            if (NamaBarang.IsNotNullOrEmpty() && Tanggal.IsNotNullOrEmpty() && Status.IsNotNullOrEmpty())
            {
               cmd = new SqlCommand($"delete from tb_lelang where id_lelang = {ID}", cn);
               cmd.ExecuteNonQuery();

               MessageBox.Show("Berhasil menghapus lelang!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               txtIDLelang.ResetText();
               cbNamaBarangLelang.ResetText();
               dtTanggalLelang.Value = DateTime.Now;
               txtNamaPemenangLelang.ResetText();
               txtHargaAkhirLelang.ResetText();
               txtNamaPenjualLelang.ResetText();
               cbStatusLelang.ResetText();

               tblLelangLoad();
               pnlDialogLelang.Visible = false;
            }
            else
            {
               MessageBox.Show("Isi semua field terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Delete Step {Step} = {ex.Message}");
         }
      }

      private void tblLelang_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         if (tblLelang.Columns[e.ColumnIndex].Name == "btnEditLelang" && tblLelang.Columns[e.ColumnIndex].Visible == true)
         {
            
            cbNamaBarangLelangLoad();

            int rowindex = tblLelang.CurrentRow.Index;

            if (tblLelang.Rows[rowindex].Cells["Status"].Value.ToString() == "Sold Out")
            {
               MessageBox.Show("Barang sudah Sold Out!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return;
            }

            cbNamaBarangLelang.Enabled = false;

            cbStatusLelang.Enabled = true;

            txtIDLelang.Text = tblLelang.Rows[rowindex].Cells["ID"].Value.ToString();
            cbNamaBarangLelang.Text = tblLelang.Rows[rowindex].Cells["Nama_Barang"].Value.ToString();
            dtTanggalLelang.Value = tblLelang.Rows[rowindex].Cells["Tanggal"].Value.ToDateTime();
            txtNamaPemenangLelang.Text = tblLelang.Rows[rowindex].Cells["Nama_Pemenang"].Value.ToString();
            txtHargaAkhirLelang.Text = tblLelang.Rows[rowindex].Cells["Harga_Akhir"].Value.ToString();
            cbStatusLelang.Text = tblLelang.Rows[rowindex].Cells["Status"].Value.ToString();

            formState = "Edit Lelang";

            lblDialogLelang.Text = $"Edit Lelang({cbNamaBarangLelang.Text})";
            btnDeleteLelang.Visible = true;

            pnlDialogLelang.Visible = true;
            pnlDialogLelang.BringToFront();
         }
      }

      private void tblLelangLoad()
      {
         int Step = 0;
         table = new DataTable();
         try
         {
            Step = 1;
            cmd = new SqlCommand($"select tb_lelang.id_lelang as ID, tb_lelang.id_barang as BarangID, tb_lelang.id_user as UserID, tb_lelang.id_petugas as PetugasID, " +
               $"tb_barang.nama_barang as Nama_Barang, tb_lelang.tgl_lelang as Tanggal, ifnull(tb_masyarakat.nama_lengkap, '-') as Nama_Pemenang, " +
               $"ifnull(tb_lelang.harga_akhir, '-') as Harga_Akhir, ifnull(tb_petugas.nama_petugas, '-') as Nama_Penjual, tb_lelang.status as Status " +
               $"FROM tb_lelang INNER JOIN tb_barang on tb_lelang.id_barang = tb_barang.id_barang LEFT JOIN tb_petugas on tb_lelang.id_petugas = tb_petugas.id_petugas " +
               $"LEFT JOIN tb_masyarakat on tb_lelang.id_user = tb_masyarakat.id_user where tb_barang.nama_barang like '%{txtSearchLelang.Text}%' " +
               $"or tb_masyarakat.nama_lengkap like '%{txtSearchLelang.Text}%'", cn);
            table.Load(cmd.ExecuteReader());

            Step = 2;

            if (txtFilterTanggalLelang.Text.IsNotNullOrEmpty() && cbFilterStatusLelang.Text.IsNotNullOrEmpty())
            {
               table.DefaultView.RowFilter = $"Tanggal = '{txtFilterTanggalLelang.Text}' AND Status = '{cbFilterStatusLelang.Text}'";
            }
            else if (txtFilterTanggalLelang.Text.IsNotNullOrEmpty())
            {
               table.DefaultView.RowFilter = $"Tanggal = '{txtFilterTanggalLelang.Text}'";
            }
            else if (cbFilterStatusLelang.Text.IsNotNullOrEmpty())
            {
               table.DefaultView.RowFilter = $"Status = '{cbFilterStatusLelang.Text}'";
            }

            tblLelang.DataSource = table;

            Step = 3;
            DataGridViewButtonColumn btnEditLelang = new DataGridViewButtonColumn
            {
               UseColumnTextForButtonValue = true,
               Name = "btnEditLelang",
               HeaderText = "Edit",
               Text = "Edit",
               DefaultCellStyle = new DataGridViewCellStyle
               {
                  Alignment = DataGridViewContentAlignment.MiddleCenter
               }
            };

            if (btnNewLelang.Enabled == false)
            {
               btnEditLelang.Visible = false;
            }

            Step = 4;
            tblLelang.Columns.Add(btnEditLelang);
            if (tblLelang.Columns.Count == 12)
            {
               tblLelang.Columns.RemoveAt(11);
            }

            tblLelang.Columns["BarangID"].Visible = false;
            tblLelang.Columns["UserID"].Visible = false;
            tblLelang.Columns["PetugasID"].Visible = false;
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Load Step {Step} = {ex.Message}");
         }
      }

      private void cbNamaBarangLelangLoad()
      {
         int Step = 0;
         table = new DataTable();
         try
         {
            Step = 1;
            cmd = new SqlCommand($"select tb_barang.id_barang as ID, tb_barang.nama_barang as Nama from tb_barang", cn);
            table.Load(cmd.ExecuteReader());

            cbNamaBarangLelang.DataSource = table;
            cbNamaBarangLelang.ValueMember = "ID";
            cbNamaBarangLelang.DisplayMember = "Nama";
            cbNamaBarangLelang.Text = "";
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error Load Step {Step} = {ex.Message}");
         }
      }


		#endregion

		private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
