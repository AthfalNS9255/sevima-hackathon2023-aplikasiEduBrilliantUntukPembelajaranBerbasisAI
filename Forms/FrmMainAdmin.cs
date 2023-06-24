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

      
	}
}
