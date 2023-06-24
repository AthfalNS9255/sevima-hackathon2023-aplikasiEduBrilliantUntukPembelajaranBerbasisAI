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
		EduBrilliantEntities db = new EduBrilliantEntities();

      public FrmLogin()
      {
         InitializeComponent();
      }

      private void FrmLogin_Load(object sender, EventArgs e)
      {
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
         txtEmailReg.Text = "";
      }

      private void btnNavRegister_Click(object sender, EventArgs e)
      {
         ClearFields();
         pnlLogin.Visible = false;
         pnlRegister.Visible = true;
         Height = 581;
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

				User user = db.Users.Where(x => x.Username == Username && x.Password == HashPasword).FirstOrDefault();
            if (user == null)
            {
					MessageBox.Show("Username dan/atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
            }

				if (user.Role == "Admin")
				{
					FrmMainAdmin frm = new FrmMainAdmin();
					frm.Show();
				}
				else if (user.Role == "Guru")
				{
					FrmMainGuru frm = new FrmMainGuru();
					frm.Show();
				}
				else if (user.Role == "Siswa")
				{

				}

				Hide();
			}
         else
         {
            MessageBox.Show("Semua field wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void btnRegister_Click(object sender, EventArgs e)
      {
         if (txtUsernameReg.Text.IsNotNullOrEmpty() && txtNamaLengkapReg.Text.IsNotNullOrEmpty() && txtPasswordReg.Text.IsNotNullOrEmpty() && 
            txtConfirmPasswordReg.Text.IsNotNullOrEmpty() && txtEmailReg.Text.IsNotNullOrEmpty() && txtNoTelpReg.Text.IsNotNullOrEmpty())
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

            if ((!txtNoTelpReg.Text.StartsWith("+62") && !txtNoTelpReg.Text.StartsWith("08")) || txtNoTelpReg.Text.Length < 10 || txtNoTelpReg.Text.Length > 14)
            {
               MessageBox.Show("Format nomor telepon salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }

				if (!txtEmailReg.Text.IsValidEmail())
				{
					MessageBox.Show("Format Email salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

            string Password = txtPasswordReg.Text.Trim();

            SHA256 sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(Password));

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
               sb.Append(bytes[i].ToString("x2"));
            }

            string HashPassword = sb.ToString();

				User user = new User();
				user.Username = txtUsernameReg.Text.Trim();
				user.NamaLengkap = txtNamaLengkapReg.Text.Trim();
				user.Password = HashPassword;
				user.Role = "User";
				user.Email = txtEmailReg.Text.Trim();
				user.NoTelp = txtNoTelpReg.Text.Trim();

				db.Users.Add(user);
            if (db.SaveChanges() == 1)
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

		private void ControlBoxClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}

	public class Session
   {
      public static int UserID { get; set; }
   }
}
