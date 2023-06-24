using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EduBrilliant.Properties;

namespace EduBrilliant
{
   public partial class FrmLogin : Form
   {
      public static SqlConnection cn;
      SqlCommand cmd;
      SqlDataReader dr;

      public FrmLogin()
      {
         InitializeComponent();
      }

      private void FrmLogin_Load(object sender, EventArgs e)
      {
			cn = new SqlConnection(@"Data Source=DESKTOP-6I160VI\SQLEXPRESS;Initial Catalog=GrandHotel;integrated security=true;");
			cn.Open();

			Height = 446;
      }

      private void ClearFields()
      {
         txtLoginUsername.Text = "";
         txtLoginPassword.Text = "";

         txtUsernameReg.Text = "";
         txtNamaLengkapReg.Text = "";
         txtPasswordReg.Text = "";
         txtConfirmPasswordReg.Text = "";
         txtNoTelpReg.Text = "";
      }

      private void btnNavRegister_Click(object sender, EventArgs e)
      {
         ClearFields();
         pnlLogin.Visible = false;
         pnlRegister.Visible = true;
         Height = 564;
         CenterToScreen();
      }

      private void btnNavLogin_Click(object sender, EventArgs e)
      {
         ClearFields();
         pnlRegister.Visible = false;
         pnlLogin.Visible = true;
         Height = 446;
         CenterToScreen();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         if (txtLoginUsername.Text.IsNotNullOrEmpty() || txtLoginPassword.Text.IsNotNullOrEmpty())
         {
            if (txtLoginPassword.Text.Length < 8)
            {
               MessageBox.Show("Password minimal 8 karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            string Username = txtLoginUsername.Text.Trim();
            string Password = txtLoginPassword.Text.Trim();

            SHA256 sha256hash = SHA256.Create();
            byte[] bytes = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(Password));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
               sb.Append(bytes[i].ToString("x2"));
            }

            string HashPasword = sb.ToString();

            cmd = new SqlCommand($"SELECT * FROM tb_masyarakat WHERE username = '{Username}' AND password = '{HashPasword}'", cn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
               dr.Close();

               cmd = new SqlCommand($"SELECT * FROM tb_petugas WHERE username = '{Username}' AND password = '{HashPasword}'", cn);
               dr = cmd.ExecuteReader();
               if (dr.Read())
               {
                  Hide();
                  //FrmMainAdmin frmMainAdmin = new FrmMainAdmin();

                  //DataLogin.UserID = dr.GetInt32(0);

                  //if (dr.GetInt32(4) == 1)
                  //{
                  //   frmMainAdmin.btnPetugas.Visible = true;
                  //   frmMainAdmin.btnNewLelang.Enabled = false;
                  //   frmMainAdmin.Show();
                  //}
                  //else if (dr.GetInt32(4) == 2)
                  //{
                  //   frmMainAdmin.btnPetugas.Visible = false;
                  //   frmMainAdmin.btnNewLelang.Enabled = true;
                  //   frmMainAdmin.Show();
                  //}
               }
               else
               {
                  MessageBox.Show("Username dan/atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }

               dr.Close();
            }
            else
            {
               Hide();

               //FrmMainMasyarakat frmMainMasyarakat = new FrmMainMasyarakat();

               //DataLogin.UserID = dr.GetInt32(0);

               //frmMainMasyarakat.Show();
            }

            dr.Close();
         }
         else
         {
            MessageBox.Show("Semua field wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void btnRegister_Click(object sender, EventArgs e)
      {
         if (txtUsernameReg.Text.IsNotNullOrEmpty() && txtNamaLengkapReg.Text.IsNotNullOrEmpty() && txtPasswordReg.Text.IsNotNullOrEmpty() && 
            txtConfirmPasswordReg.Text.IsNotNullOrEmpty() && txtNoTelpReg.Text.IsNotNullOrEmpty())
         {
            if (txtPasswordReg.Text.Length < 8)
            {
               MessageBox.Show("Password minimal harus 8 huruf!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            if (txtPasswordReg.Text != txtConfirmPasswordReg.Text)
            {
               MessageBox.Show("Password harus sama dengan Confirm Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            if (!txtNoTelpReg.Text.StartsWith("+62") && !txtNoTelpReg.Text.StartsWith("08") || txtNoTelpReg.Text.Length < 10 || txtNoTelpReg.Text.Length > 13)
            {
               MessageBox.Show("Format nomor telepon salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

            string Username = txtUsernameReg.Text.Trim();
            string NamaLengkap = txtNamaLengkapReg.Text.Trim();
            string Password = txtPasswordReg.Text.Trim();
            string ConfirmPassword = txtConfirmPasswordReg.Text.Trim();
            string NoTelp = txtNoTelpReg.Text.Trim();

            SHA256 sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(Password));

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
               sb.Append(bytes[i].ToString("x2"));
            }

            string HashPassword = sb.ToString();

            cmd = new SqlCommand($"registrasiMasyarakat", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nama", NamaLengkap);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", HashPassword);
            cmd.Parameters.AddWithValue("@NoTelp", NoTelp);

            if (cmd.ExecuteNonQuery() == 1)
            {
               DialogResult dialogResult =  MessageBox.Show("Anda berhasil Registrasi!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               if (dialogResult == DialogResult.OK)
               {
                  ClearFields();

                  pnlRegister.Visible = false;
                  pnlLogin.Visible = true;
               }
            }
         }
         else
         {
            MessageBox.Show("Pastikan isi semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void txtLoginPassword_IconRightClick(object sender, EventArgs e)
      {
         if (txtLoginPassword.UseSystemPasswordChar == true)
         {
            txtLoginPassword.UseSystemPasswordChar = false;
            txtLoginPassword.PasswordChar = '\0';
            txtLoginPassword.IconRight = Resources.icons8_eye_24;
         }
         else
         {
            txtLoginPassword.UseSystemPasswordChar = true;
            txtLoginPassword.IconRight = Resources.icons8_hide_24;
         }
      }
   }

   public class DataLogin
   {
      public static int UserID { get; set; }
   }
}
