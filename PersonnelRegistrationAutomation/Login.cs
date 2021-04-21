using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonnelRegistrationAutomation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonelVerıTabanı;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Yonetici where KullaniciAd=@l1 and Sifre=@l2", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@l1", TxtLoginName.Text);
            sqlCommand.Parameters.AddWithValue("@l2", TxtPassword.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                PersonnelMain personnelMain = new PersonnelMain();
                personnelMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password");
                
            }

            sqlConnection.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
