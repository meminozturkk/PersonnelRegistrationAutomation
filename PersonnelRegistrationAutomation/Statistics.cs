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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonelVerıTabanı;Integrated Security=True");
        private void Statistics_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            //Total Personnel
            SqlCommand sqlCommand = new SqlCommand("Select Count(*) from Tbl_Personel", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LblTotPer.Text = sqlDataReader[0].ToString();
            }
            sqlDataReader.Close();
            // Different City
            SqlCommand sqlCommand1 = new SqlCommand("Select Count(distinct(PerSehir)) from Tbl_Personel", sqlConnection); 
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                LblDifCity.Text = sqlDataReader1[0].ToString();
            }
            sqlDataReader1.Close();
            //Total Salary
            SqlCommand sqlCommand2 = new SqlCommand("select sum(PerMaas) from Tbl_Personel", sqlConnection);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            while (sqlDataReader2.Read())
            {
                LblTotSalary.Text = sqlDataReader2[0].ToString();
            }
            sqlDataReader2.Close();
            //Average Salary
            SqlCommand sqlCommand3 = new SqlCommand("select avg(PerMaas) from Tbl_Personel", sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                LblAvgSalary.Text = sqlDataReader3[0].ToString();
            }
            sqlDataReader3.Close();
            //Married Person
            SqlCommand sqlCommand4 = new SqlCommand("select count(PerDurum) from Tbl_Personel where PerDurum = 1", sqlConnection);
            SqlDataReader sqlDataReader4 = sqlCommand4.ExecuteReader();
            while (sqlDataReader4.Read())
            {
                LblMarried.Text = sqlDataReader4[0].ToString();
            }
            sqlConnection.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FromClosed(object sender, FormClosedEventArgs e)
        {
            PersonnelMain personnelMain = new PersonnelMain();
            personnelMain.Close();
        }

        private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
