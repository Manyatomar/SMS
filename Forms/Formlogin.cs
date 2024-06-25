using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using WindowFormsApp1.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowFormsApp1
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            DbClass dbClass = new DbClass();    
            var IsValidate = dbClass.ValidateCredential(username, password);
            
            if (IsValidate)
            {
                this.Hide();
                frmMDI frm = new frmMDI();
                frm.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("incorrect credential!");
            }  

        }
        
        
    }
}